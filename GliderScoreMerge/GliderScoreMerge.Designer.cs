namespace GliderScoreMerge
{
    partial class GliderScoreMerge
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgTimerNames = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TimerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MergeButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lZipFileName = new System.Windows.Forms.Label();
            this.bChangeGliderScoreDirectory = new System.Windows.Forms.Button();
            this.lGliderScoreDirectory = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTimerNames)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select .zip file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "zip";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "GliderScore zip file|*.zip";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 261);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgTimerNames);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(545, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Timers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgTimerNames
            // 
            this.dgTimerNames.AllowUserToAddRows = false;
            this.dgTimerNames.AllowUserToDeleteRows = false;
            this.dgTimerNames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTimerNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTimerNames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimerName,
            this.MergeButton});
            this.dgTimerNames.Location = new System.Drawing.Point(3, 3);
            this.dgTimerNames.Name = "dgTimerNames";
            this.dgTimerNames.ReadOnly = true;
            this.dgTimerNames.Size = new System.Drawing.Size(536, 150);
            this.dgTimerNames.TabIndex = 0;
            this.dgTimerNames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTimerNames_CellContentClick);
            this.dgTimerNames.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgTimerNames_CellFormatting);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pilots";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TimerName
            // 
            this.TimerName.DataPropertyName = "TimerName";
            this.TimerName.HeaderText = "Name";
            this.TimerName.Name = "TimerName";
            this.TimerName.ReadOnly = true;
            // 
            // MergeButton
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.MergeButton.DefaultCellStyle = dataGridViewCellStyle4;
            this.MergeButton.HeaderText = "";
            this.MergeButton.Name = "MergeButton";
            this.MergeButton.ReadOnly = true;
            // 
            // lZipFileName
            // 
            this.lZipFileName.AutoSize = true;
            this.lZipFileName.Location = new System.Drawing.Point(124, 21);
            this.lZipFileName.Name = "lZipFileName";
            this.lZipFileName.Size = new System.Drawing.Size(0, 13);
            this.lZipFileName.TabIndex = 3;
            // 
            // bChangeGliderScoreDirectory
            // 
            this.bChangeGliderScoreDirectory.AutoSize = true;
            this.bChangeGliderScoreDirectory.Location = new System.Drawing.Point(13, 51);
            this.bChangeGliderScoreDirectory.Name = "bChangeGliderScoreDirectory";
            this.bChangeGliderScoreDirectory.Size = new System.Drawing.Size(157, 23);
            this.bChangeGliderScoreDirectory.TabIndex = 4;
            this.bChangeGliderScoreDirectory.Text = "Change GliderScore Directory";
            this.bChangeGliderScoreDirectory.UseVisualStyleBackColor = true;
            this.bChangeGliderScoreDirectory.Click += new System.EventHandler(this.bChangeGliderScoreDirectory_Click);
            // 
            // lGliderScoreDirectory
            // 
            this.lGliderScoreDirectory.AutoSize = true;
            this.lGliderScoreDirectory.Location = new System.Drawing.Point(176, 56);
            this.lGliderScoreDirectory.Name = "lGliderScoreDirectory";
            this.lGliderScoreDirectory.Size = new System.Drawing.Size(35, 13);
            this.lGliderScoreDirectory.TabIndex = 5;
            this.lGliderScoreDirectory.Text = "label1";
            // 
            // GliderScoreMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 580);
            this.Controls.Add(this.lGliderScoreDirectory);
            this.Controls.Add(this.bChangeGliderScoreDirectory);
            this.Controls.Add(this.lZipFileName);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "GliderScoreMerge";
            this.Text = "GliderScoreMerge";
            this.Load += new System.EventHandler(this.GliderScoreMerge_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTimerNames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgTimerNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimerName;
        private System.Windows.Forms.DataGridViewButtonColumn MergeButton;
        private System.Windows.Forms.Label lZipFileName;
        private System.Windows.Forms.Button bChangeGliderScoreDirectory;
        private System.Windows.Forms.Label lGliderScoreDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

