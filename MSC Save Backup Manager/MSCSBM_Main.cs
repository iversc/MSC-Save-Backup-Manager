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

        public MSCSBM_Main()
        {
            InitializeComponent();

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
        }

        private void btnOpenBackups_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", BackupFolder);
        }

        private void updateView()
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

        private void btnPerformBackup_Click(object sender, EventArgs e)
        {
            string BackupFileName = "MSC-Save-Backup_" + DateTime.Now.ToString("yyyy-MM-ddTHH-mm-ss");
            string comment = tbComment.Text;
            if (comment.Length > 50) comment = comment.Substring(0, 50);

            BackupFileName += (comment != "") ? "_" + comment : "";
            BackupFileName += ".zip";

            using (ZipArchive archive = ZipFile.Open(Path.Combine(BackupFolder, BackupFileName), ZipArchiveMode.Update))
            {
                archive.CreateEntryFromFile(Path.Combine(SavePath, "defaultES2File.txt"), "defaultES2File.txt");
                archive.CreateEntryFromFile(Path.Combine(SavePath, "items.txt"), "items.txt");

                foreach (string fileName in Directory.GetFiles(SavePath, "*.xml"))
                {
                    archive.CreateEntryFromFile(fileName, Path.GetFileName(fileName));
                }

                foreach (string fileName in Directory.GetFiles(SavePath, "*.cfg"))
                {
                    archive.CreateEntryFromFile(fileName, Path.GetFileName(fileName));
                }
            }

            updateView();
            tsStatus.Text = "Backup Complete!";
        }

        private void btnPerformRestore_Click(object sender, EventArgs e)
        {
            BackupFileItem bfi = (BackupFileItem)cbRestoreFile.SelectedItem;

            if (bfi == null)
            {
                tsStatus.Text = "Please select a file to restore.";
                return;
            }

            using (ZipArchive archive = ZipFile.OpenRead(bfi.FilePath))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    entry.ExtractToFile(Path.Combine(SavePath, entry.Name), true);
                }
            }

            tsStatus.Text = "Restored backup " + bfi.DisplayName;
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
