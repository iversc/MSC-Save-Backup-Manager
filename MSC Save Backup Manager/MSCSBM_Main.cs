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
        }

        private void btnOpenBackups_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", BackupFolder);
        }

        private void updateTimestamp()
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
            updateTimestamp();
        }

        private void btnOpenSaves_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", SavePath);
        }

        private void btnPerformBackup_Click(object sender, EventArgs e)
        {
            string BackupFileName = "MSC-Save-Backup_" + DateTime.Now.ToString("yyyy-MM-ddThh-mm-ss");
            BackupFileName += (tbComment.Text != "") ? "_" + tbComment.Text : "";
            BackupFileName += ".zip";

            using (ZipArchive archive = ZipFile.Open(Path.Combine(BackupFolder, BackupFileName), ZipArchiveMode.Update))
            {
                archive.CreateEntryFromFile(Path.Combine(SavePath, "defaultES2File.txt"), "defaultES2File.txt");
                archive.CreateEntryFromFile(Path.Combine(SavePath, "items.txt"), "items.txt");
            }

            tsStatus.Text = "Backup Complete!";
        }
    }
}
