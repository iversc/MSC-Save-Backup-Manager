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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOpenBackups = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.btnPerformBackup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnPerformRestore = new System.Windows.Forms.Button();
            this.btnOpenSaves = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(461, 160);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPerformBackup);
            this.tabPage1.Controls.Add(this.tbComment);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblTimestamp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(453, 134);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backup";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPerformRestore);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(453, 140);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Restore";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comment:";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(68, 76);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(173, 20);
            this.tbComment.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Backup:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(346, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btnPerformRestore
            // 
            this.btnPerformRestore.Location = new System.Drawing.Point(109, 32);
            this.btnPerformRestore.Name = "btnPerformRestore";
            this.btnPerformRestore.Size = new System.Drawing.Size(222, 102);
            this.btnPerformRestore.TabIndex = 2;
            this.btnPerformRestore.Text = "Restore Save";
            this.btnPerformRestore.UseVisualStyleBackColor = true;
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
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 195);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(460, 22);
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
            this.Name = "MSCSBM_Main";
            this.Text = "MSC Save Backup Manager";
            this.Activated += new System.EventHandler(this.MSCSBM_Main_Activated);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTimestamp;
        private System.Windows.Forms.Button btnOpenBackups;
        private System.Windows.Forms.Button btnPerformBackup;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPerformRestore;
        private System.Windows.Forms.Button btnOpenSaves;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
    }
}

