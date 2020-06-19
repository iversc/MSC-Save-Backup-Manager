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
            this.tabPageSnapshot = new System.Windows.Forms.TabPage();
            this.numKeptSnapshots = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSnapshotEnabled = new System.Windows.Forms.CheckBox();
            this.btnOpenBackups = new System.Windows.Forms.Button();
            this.btnOpenSaves = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPageBackup.SuspendLayout();
            this.tabPageRestore.SuspendLayout();
            this.tabPageSnapshot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKeptSnapshots)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPageSnapshot);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(461, 160);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBackup
            // 
            this.tabPageBackup.Controls.Add(this.btnPerformBackup);
            this.tabPageBackup.Controls.Add(this.tbComment);
            this.tabPageBackup.Controls.Add(this.label1);
            this.tabPageBackup.Controls.Add(this.lblTimestamp);
            this.tabPageBackup.Location = new System.Drawing.Point(4, 22);
            this.tabPageBackup.Name = "tabPageBackup";
            this.tabPageBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBackup.Size = new System.Drawing.Size(453, 134);
            this.tabPageBackup.TabIndex = 0;
            this.tabPageBackup.Text = "Backup";
            this.tabPageBackup.UseVisualStyleBackColor = true;
            // 
            // btnPerformBackup
            // 
            this.btnPerformBackup.Location = new System.Drawing.Point(287, 15);
            this.btnPerformBackup.Name = "btnPerformBackup";
            this.btnPerformBackup.Size = new System.Drawing.Size(151, 107);
            this.btnPerformBackup.TabIndex = 4;
            this.btnPerformBackup.Text = "Backup Now!";
            this.btnPerformBackup.UseVisualStyleBackColor = true;
            this.btnPerformBackup.Click += new System.EventHandler(this.btnPerformBackup_Click);
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(68, 76);
            this.tbComment.MaxLength = 50;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(173, 20);
            this.tbComment.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comment:";
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.AutoSize = true;
            this.lblTimestamp.Location = new System.Drawing.Point(8, 33);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(210, 13);
            this.lblTimestamp.TabIndex = 0;
            this.lblTimestamp.Text = "Save Timestamp: 0000-00-00 00:00:00 XM";
            // 
            // tabPageRestore
            // 
            this.tabPageRestore.Controls.Add(this.btnPerformRestore);
            this.tabPageRestore.Controls.Add(this.cbRestoreFile);
            this.tabPageRestore.Controls.Add(this.label2);
            this.tabPageRestore.Location = new System.Drawing.Point(4, 22);
            this.tabPageRestore.Name = "tabPageRestore";
            this.tabPageRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRestore.Size = new System.Drawing.Size(453, 134);
            this.tabPageRestore.TabIndex = 1;
            this.tabPageRestore.Text = "Restore";
            this.tabPageRestore.UseVisualStyleBackColor = true;
            // 
            // btnPerformRestore
            // 
            this.btnPerformRestore.Location = new System.Drawing.Point(109, 30);
            this.btnPerformRestore.Name = "btnPerformRestore";
            this.btnPerformRestore.Size = new System.Drawing.Size(222, 102);
            this.btnPerformRestore.TabIndex = 2;
            this.btnPerformRestore.Text = "Restore Save";
            this.btnPerformRestore.UseVisualStyleBackColor = true;
            this.btnPerformRestore.Click += new System.EventHandler(this.btnPerformRestore_Click);
            // 
            // cbRestoreFile
            // 
            this.cbRestoreFile.FormattingEnabled = true;
            this.cbRestoreFile.Location = new System.Drawing.Point(94, 5);
            this.cbRestoreFile.Name = "cbRestoreFile";
            this.cbRestoreFile.Size = new System.Drawing.Size(346, 21);
            this.cbRestoreFile.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Backup:";
            // 
            // tabPageSnapshot
            // 
            this.tabPageSnapshot.Controls.Add(this.numKeptSnapshots);
            this.tabPageSnapshot.Controls.Add(this.label3);
            this.tabPageSnapshot.Controls.Add(this.cbSnapshotEnabled);
            this.tabPageSnapshot.Location = new System.Drawing.Point(4, 22);
            this.tabPageSnapshot.Name = "tabPageSnapshot";
            this.tabPageSnapshot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSnapshot.Size = new System.Drawing.Size(453, 134);
            this.tabPageSnapshot.TabIndex = 2;
            this.tabPageSnapshot.Text = "Auto-Snapshot";
            this.tabPageSnapshot.UseVisualStyleBackColor = true;
            // 
            // numKeptSnapshots
            // 
            this.numKeptSnapshots.Enabled = false;
            this.numKeptSnapshots.Location = new System.Drawing.Point(163, 38);
            this.numKeptSnapshots.Name = "numKeptSnapshots";
            this.numKeptSnapshots.Size = new System.Drawing.Size(120, 20);
            this.numKeptSnapshots.TabIndex = 2;
            this.numKeptSnapshots.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numKeptSnapshots.ValueChanged += new System.EventHandler(this.numKeptSnapshots_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number of snapshots to keep:";
            // 
            // cbSnapshotEnabled
            // 
            this.cbSnapshotEnabled.AutoSize = true;
            this.cbSnapshotEnabled.Location = new System.Drawing.Point(8, 6);
            this.cbSnapshotEnabled.Name = "cbSnapshotEnabled";
            this.cbSnapshotEnabled.Size = new System.Drawing.Size(231, 17);
            this.cbSnapshotEnabled.TabIndex = 0;
            this.cbSnapshotEnabled.Text = "Enable automatic save snapshots/backups";
            this.cbSnapshotEnabled.UseVisualStyleBackColor = true;
            this.cbSnapshotEnabled.CheckedChanged += new System.EventHandler(this.cbSnapshotEnabled_CheckedChanged);
            // 
            // btnOpenBackups
            // 
            this.btnOpenBackups.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOpenBackups.Location = new System.Drawing.Point(6, 165);
            this.btnOpenBackups.Name = "btnOpenBackups";
            this.btnOpenBackups.Size = new System.Drawing.Size(222, 23);
            this.btnOpenBackups.TabIndex = 1;
            this.btnOpenBackups.Text = "Open Backups Folder";
            this.btnOpenBackups.UseVisualStyleBackColor = true;
            this.btnOpenBackups.Click += new System.EventHandler(this.btnOpenBackups_Click);
            // 
            // btnOpenSaves
            // 
            this.btnOpenSaves.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOpenSaves.Location = new System.Drawing.Point(234, 165);
            this.btnOpenSaves.Name = "btnOpenSaves";
            this.btnOpenSaves.Size = new System.Drawing.Size(222, 23);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 195);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(460, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(39, 17);
            this.tsStatus.Text = "Ready";
            // 
            // MSCSBM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 217);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnOpenSaves);
            this.Controls.Add(this.btnOpenBackups);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MSCSBM_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MSC Save Backup Manager v2.0";
            this.Activated += new System.EventHandler(this.MSCSBM_Main_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MSCSBM_Main_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBackup.ResumeLayout(false);
            this.tabPageBackup.PerformLayout();
            this.tabPageRestore.ResumeLayout(false);
            this.tabPageRestore.PerformLayout();
            this.tabPageSnapshot.ResumeLayout(false);
            this.tabPageSnapshot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKeptSnapshots)).EndInit();
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
        private System.Windows.Forms.TabPage tabPageSnapshot;
        private System.Windows.Forms.NumericUpDown numKeptSnapshots;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbSnapshotEnabled;
    }
}

