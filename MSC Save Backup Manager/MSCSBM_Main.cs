using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO.Compression;

namespace MSC_Save_Backup_Manager
{
    public partial class MSCSBM_Main : Form
    {
        string SavePath = "";
        string BackupFolder = "";
        BackupFileItem[] backupFiles;
        FileSystemWatcher saveWatcher;
        int snapshotFileWatchStage = 0;
        private delegate void SafeUpdateStatus(string newStatus, Color newColor);
        private delegate void SafeUpdateView();

        public MSCSBM_Main()
        {
            InitializeComponent();
            Debug.WriteLine("Test");

            //KNOWNFOLDERID of the LocalLow folder, for use in the SHGetKnownFolderPath Win32 API call.
            //
            //Used to make sure the system gives us the correct path, in case the folder name or location
            //ever changes.
            Guid FOLDERID_LocalAppDataLow = new Guid("A520A1A4-1780-4FF6-BD18-167343C5AF16");

            //Set up our default paths
            SavePath = Path.Combine(GetKnownFolderPath(FOLDERID_LocalAppDataLow), @"Amistech\My Summer Car");
            BackupFolder = Path.Combine(SavePath, "backups");

            //Create backup folder if necessary
            Directory.CreateDirectory(BackupFolder);

            backupFiles = new BackupFileItem[0];

            saveWatcher = new FileSystemWatcher(SavePath);
            saveWatcher.NotifyFilter = NotifyFilters.LastWrite;
            saveWatcher.Changed += SaveFileChanged;

            numKeptSnapshots.Value = Properties.Settings.Default.SnapshotCount;
            cbSnapshotEnabled.Checked = Properties.Settings.Default.SnapshotEnabled;
        }

        private void btnOpenBackups_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", BackupFolder);
        }

        private void updateView()
        {
            if (lblTimestamp.InvokeRequired)
            {
                var d = new SafeUpdateView(updateView);
                lblTimestamp.Invoke(d);
            }
            else
            {
                //Grab the current save file timestamp
                FileInfo fi = new FileInfo(Path.Combine(SavePath, "defaultES2File.txt"));

                if (fi.Exists)
                {
                    DateTime saveFileTime = fi.LastWriteTime;
                    lblTimestamp.Text = "Save Timestamp: " + saveFileTime.ToString("g");

                    btnPerformBackup.Enabled = true;
                }
                else
                {
                    lblTimestamp.Text = "!! No MSC save found !!";
                    btnPerformBackup.Enabled = false;
                }

                //Search for backup files
                string[] listFiles = Directory.GetFiles(BackupFolder, "*.zip");

                tsStatus.Text = listFiles.Length.ToString() + " backup(s) found";

                //Skip reloading the backup file list if it hasn't changed
                if (listFiles.Length != backupFiles.Length)
                {
                    backupFiles = new BackupFileItem[listFiles.Length];

                    for (int i = 0; i < listFiles.Length; i++)
                    {
                        backupFiles[i] = new BackupFileItem();

                        backupFiles[i].FilePath = listFiles[i];

                        string fileName = Path.GetFileName(listFiles[i]);
                        string fileDate = fileName.Substring(16, 19);
                        string comment = "";

                        if (fileName[35] == '_')
                        {
                            comment = " - " + fileName.Substring(36).Split('.')[0];
                        }

                        string fileTime = fileDate.Split('T')[1];
                        fileTime = fileTime.Replace('-', ':');
                        fileDate = fileDate.Split('T')[0] + "T" + fileTime;
                        string displayName = DateTime.Parse(fileDate).ToString("g") + comment;
                        backupFiles[i].DisplayName = displayName;

                    }

                    cbRestoreFile.Items.Clear();
                    cbRestoreFile.Items.AddRange(backupFiles);
                }

                btnPerformRestore.Enabled = !(listFiles.Length == 0);
            }
        }

        private string GetKnownFolderPath(Guid knownFolderId)
        {
            IntPtr pszPath = IntPtr.Zero;
            try
            {
                int hr = SHGetKnownFolderPath(knownFolderId, 0, IntPtr.Zero, out pszPath);
                if (hr >= 0)
                    return Marshal.PtrToStringAuto(pszPath);
                throw Marshal.GetExceptionForHR(hr);
            }
            finally
            {
                if (pszPath != IntPtr.Zero)
                    Marshal.FreeCoTaskMem(pszPath);
            }
        }

        [DllImport("shell32.dll")]
        static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags, IntPtr hToken, out IntPtr pszPath);

        private void MSCSBM_Main_Activated(object sender, EventArgs e)
        {
            //Whenever we become the active window again, update the save timestamp(and disable/enable the button)
            updateView();
        }

        private void btnOpenSaves_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", SavePath);
        }

        private void doBackup(string comment)
        {
            string BackupFileName = "MSC-Save-Backup_" + DateTime.Now.ToString("yyyy-MM-ddTHH-mm-ss");

            BackupFileName += (comment != "") ? "_" + comment : "";
            BackupFileName += ".zip";

            using (ZipArchive archive = ZipFile.Open(Path.Combine(BackupFolder, BackupFileName), ZipArchiveMode.Update))
            {
                foreach (string fileName in Directory.GetFiles(SavePath))
                {
                    archive.CreateEntryFromFile(fileName, Path.GetFileName(fileName));
                }
            }
        }

        private void btnPerformBackup_Click(object sender, EventArgs e)
        {
            string comment = tbComment.Text;
            if (comment.Length > 50) comment = comment.Substring(0, 50);

            doBackup(comment);

            updateView();
            tsStatus.ForeColor = Color.Black;
            tsStatus.Text = "Backup Complete!";
        }

        private void btnPerformRestore_Click(object sender, EventArgs e)
        {
            BackupFileItem bfi = (BackupFileItem)cbRestoreFile.SelectedItem;

            if (bfi == null)
            {
                tsStatus.ForeColor = Color.Black;
                tsStatus.Text = "Please select a file to restore.";
                return;
            }

            using (ZipArchive archive = ZipFile.OpenRead(bfi.FilePath))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    try
                    {
                        entry.ExtractToFile(Path.Combine(SavePath, entry.Name), true);
                    } 
                    catch (System.UnauthorizedAccessException uae)
                    {
                        if(entry.Name == "meshsave.txt")
                        {
                            continue;
                        }
                        else
                        {
                            string errorMessage = "Unable to restore save file " + bfi.DisplayName;
                            errorMessage += "\n\nError with file: " + entry.Name;
                            errorMessage += "\n\n\n" + uae.ToString();
                            MessageBox.Show(errorMessage, "Unable to restore", MessageBoxButtons.OK ,MessageBoxIcon.Error);

                            tsStatus.ForeColor = Color.Red;
                            tsStatus.Text = "Restore failed - " + bfi.DisplayName;
                            return;
                        }
                    }
                }
            }

            tsStatus.ForeColor = Color.Black;
            tsStatus.Text = "Restored backup " + bfi.DisplayName;
        }

        private string getSnapshotName(int snapshotNum)
        {
            string[] files = Directory.GetFiles(BackupFolder, "*_snapshot-" + snapshotNum + ".zip");

            if (files.Length == 1)
            {
                return Path.GetFileName(files[0]);
            }
            else
            {
                return null;
            }
        }

        private void rotateSnapshots()
        {
            int maxNum = Properties.Settings.Default.SnapshotCount;

            for(int i = maxNum - 1; i >= 0; i--)
            {
                string oldFileName = getSnapshotName(i);
                if (oldFileName == null) continue;

                string[] nameParts = oldFileName.Split('_');
                nameParts[2] = "snapshot-" + (i + 1) + ".zip";
                string newFileName = String.Join("_", nameParts);

                string existingSnapshotName = getSnapshotName(i + 1);
                if (existingSnapshotName != null)
                {
                    File.Delete(Path.Combine(BackupFolder, existingSnapshotName));
                }

                File.Move(Path.Combine(BackupFolder, oldFileName),
                    Path.Combine(BackupFolder, newFileName));
 
            }
        }

        private void updateStatus(string newText, Color newColor)
        {
            if (statusStrip1.InvokeRequired)
            {
                var d = new SafeUpdateStatus(updateStatus);
                statusStrip1.Invoke(d, new object[] { newText, newColor });
            }
            else
            {
                tsStatus.Text = newText;
                tsStatus.ForeColor = newColor;
            }
        }
        
        private void SaveFileChanged(object source, FileSystemEventArgs e)
        {
            if (e.Name == "items.txt")
            {
                saveWatcher.Filter = "options.txt";
            }

            if (e.Name == "options.txt")
            {
                saveWatcher.Filter = "items.txt";

                if (snapshotFileWatchStage == 1)
                {
                    saveWatcher.EnableRaisingEvents = false;

                    string time = DateTime.Now.ToString("g");
                    doBackup("snapshot-0");
                    rotateSnapshots();
 
                    updateView();

                    updateStatus("New Snapshot Created " + time, Color.Black);

                    snapshotFileWatchStage = 0;
                    saveWatcher.EnableRaisingEvents = true;
                }
                else
                {
                    snapshotFileWatchStage = 1;
                }
            }
        }

        private void cbSnapshotEnabled_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SnapshotEnabled = cbSnapshotEnabled.Checked;
            numKeptSnapshots.Enabled = cbSnapshotEnabled.Checked;

            //saveWatcher.Filter = "items.txt";
            saveWatcher.EnableRaisingEvents = cbSnapshotEnabled.Checked;
        }

        private void numKeptSnapshots_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SnapshotCount = (int)numKeptSnapshots.Value;
        }

        private void MSCSBM_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }

    class BackupFileItem
    {
        public string FilePath { get; set; }
        public string DisplayName { get; set; }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
