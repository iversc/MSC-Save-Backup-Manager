namespace MSC_Save_Backup_Manager
{
    partial class MSCSBM_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBackup = new System.Windows.Forms.TabPage();
            this.btnPerformBackup = new System.Windows.Forms.Button();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.tabPageRestore = new System.Windows.Forms.TabPage();
            this.btnPerformRestore = new System.Windows.Forms.Button();
            this.cbRestoreFile = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenBackups = new System.Windows.Forms.Button();
            this.btnOpenSaves = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPageBackup.SuspendLayout();
            this.tabPageRestore.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageBackup);
            this.tabControl1.Controls.Add(this.tabPageRestore);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(615, 197);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBackup
            // 
            this.tabPageBackup.Controls.Add(this.btnPerformBackup);
            this.tabPageBackup.Controls.Add(this.tbComment);
            this.tabPageBackup.Controls.Add(this.label1);
            this.tabPageBackup.Controls.Add(this.lblTimestamp);
            this.tabPageBackup.Location = new System.Drawing.Point(4, 25);
            this.tabPageBackup.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageBackup.Name = "tabPageBackup";
            this.tabPageBackup.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageBackup.Size = new System.Drawing.Size(607, 168);
            this.tabPageBackup.TabIndex = 0;
            this.tabPageBackup.Text = "Backup";
            this.tabPageBackup.UseVisualStyleBackColor = true;
            // 
            // btnPerformBackup
            // 
            this.btnPerformBackup.Location = new System.Drawing.Point(383, 18);
            this.btnPerformBackup.Margin = new System.Windows.Forms.Padding(4);
            this.btnPerformBackup.Name = "btnPerformBackup";
            this.btnPerformBackup.Size = new System.Drawing.Size(201, 132);
            this.btnPerformBackup.TabIndex = 4;
            this.btnPerformBackup.Text = "Backup Now!";
            this.btnPerformBackup.UseVisualStyleBackColor = true;
            this.btnPerformBackup.Click += new System.EventHandler(this.btnPerformBackup_Click);
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(91, 94);
            this.tbComment.Margin = new System.Windows.Forms.Padding(4);
            this.tbComment.MaxLength = 50;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(229, 22);
            this.tbComment.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comment:";
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.AutoSize = true;
            this.lblTimestamp.Location = new System.Drawing.Point(11, 41);
            this.lblTimestamp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(279, 17);
            this.lblTimestamp.TabIndex = 0;
            this.lblTimestamp.Text = "Save Timestamp: 0000-00-00 00:00:00 XM";
            // 
            // tabPageRestore
            // 
            this.tabPageRestore.Controls.Add(this.btnPerformRestore);
            this.tabPageRestore.Controls.Add(this.cbRestoreFile);
            this.tabPageRestore.Controls.Add(this.label2);
            this.tabPageRestore.Location = new System.Drawing.Point(4, 25);
            this.tabPageRestore.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageRestore.Name = "tabPageRestore";
            this.tabPageRestore.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageRestore.Size = new System.Drawing.Size(607, 168);
            this.tabPageRestore.TabIndex = 1;
            this.tabPageRestore.Text = "Restore";
            this.tabPageRestore.UseVisualStyleBackColor = true;
            // 
            // btnPerformRestore
            // 
            this.btnPerformRestore.Location = new System.Drawing.Point(145, 37);
            this.btnPerformRestore.Margin = new System.Windows.Forms.Padding(4);
            this.btnPerformRestore.Name = "btnPerformRestore";
            this.btnPerformRestore.Size = new System.Drawing.Size(296, 126);
            this.btnPerformRestore.TabIndex = 2;
            this.btnPerformRestore.Text = "Restore Save";
            this.btnPerformRestore.UseVisualStyleBackColor = true;
            this.btnPerformRestore.Click += new System.EventHandler(this.btnPerformRestore_Click);
            // 
            // cbRestoreFile
            // 
            this.cbRestoreFile.FormattingEnabled = true;
            this.cbRestoreFile.Location = new System.Drawing.Point(125, 6);
            this.cbRestoreFile.Margin = new System.Windows.Forms.Padding(4);
            this.cbRestoreFile.Name = "cbRestoreFile";
            this.cbRestoreFile.Size = new System.Drawing.Size(460, 24);
            this.cbRestoreFile.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Backup:";
            // 
            // btnOpenBackups
            // 
            this.btnOpenBackups.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOpenBackups.Location = new System.Drawing.Point(8, 203);
            this.btnOpenBackups.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenBackups.Name = "btnOpenBackups";
            this.btnOpenBackups.Size = new System.Drawing.Size(296, 28);
            this.btnOpenBackups.TabIndex = 1;
            this.btnOpenBackups.Text = "Open Backups Folder";
            this.btnOpenBackups.UseVisualStyleBackColor = true;
            this.btnOpenBackups.Click += new System.EventHandler(this.btnOpenBackups_Click);
            // 
            // btnOpenSaves
            // 
            this.btnOpenSaves.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOpenSaves.Location = new System.Drawing.Point(312, 203);
            this.btnOpenSaves.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenSaves.Name = "btnOpenSaves";
            this.btnOpenSaves.Size = new System.Drawing.Size(296, 28);
            this.btnOpenSaves.TabIndex = 2;
            this.btnOpenSaves.Text = "Open Saves Folder";
            this.btnOpenSaves.UseVisualStyleBackColor = true;
            this.btnOpenSaves.Click += new System.EventHandler(this.btnOpenSaves_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 241);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(613, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(50, 20);
            this.tsStatus.Text = "Ready";
            // 
            // MSCSBM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 267);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnOpenSaves);
            this.Controls.Add(this.btnOpenBackups);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MSCSBM_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MSC Save Backup Manager v1.1";
            this.Activated += new System.EventHandler(this.MSCSBM_Main_Activated);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBackup.ResumeLayout(false);
            this.tabPageBackup.PerformLayout();
            this.tabPageRestore.ResumeLayout(false);
            this.tabPageRestore.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBackup;
        private System.Windows.Forms.TabPage tabPageRestore;
        private System.Windows.Forms.Label lblTimestamp;
        private System.Windows.Forms.Button btnOpenBackups;
        private System.Windows.Forms.Button btnPerformBackup;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRestoreFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPerformRestore;
        private System.Windows.Forms.Button btnOpenSaves;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
    }
}

