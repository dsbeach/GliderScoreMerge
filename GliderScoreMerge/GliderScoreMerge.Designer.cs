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
            this.bInputZipFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dgTimerNames = new System.Windows.Forms.DataGridView();
            this.Checked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TimerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.bChangeGliderScoreDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInputZipFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOutputGliderScoreDirectory = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTimerNames)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bInputZipFile
            // 
            this.bInputZipFile.AutoSize = true;
            this.bInputZipFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInputZipFile.Location = new System.Drawing.Point(658, 8);
            this.bInputZipFile.Name = "bInputZipFile";
            this.bInputZipFile.Size = new System.Drawing.Size(91, 34);
            this.bInputZipFile.TabIndex = 0;
            this.bInputZipFile.Text = "Browse";
            this.bInputZipFile.UseVisualStyleBackColor = true;
            this.bInputZipFile.Click += new System.EventHandler(this.button1_Click);
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
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 478);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dgTimerNames);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(782, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Timers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Import selected timer scripts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgTimerNames
            // 
            this.dgTimerNames.AllowUserToAddRows = false;
            this.dgTimerNames.AllowUserToDeleteRows = false;
            this.dgTimerNames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTimerNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTimerNames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checked,
            this.TimerName});
            this.dgTimerNames.Location = new System.Drawing.Point(3, 42);
            this.dgTimerNames.Name = "dgTimerNames";
            this.dgTimerNames.ReadOnly = true;
            this.dgTimerNames.Size = new System.Drawing.Size(773, 400);
            this.dgTimerNames.TabIndex = 0;
            this.dgTimerNames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTimerNames_CellContentClick);
            // 
            // Checked
            // 
            this.Checked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Checked.DataPropertyName = "Checked";
            this.Checked.FalseValue = "false";
            this.Checked.HeaderText = "";
            this.Checked.MinimumWidth = 100;
            this.Checked.Name = "Checked";
            this.Checked.ReadOnly = true;
            this.Checked.TrueValue = "true";
            // 
            // TimerName
            // 
            this.TimerName.DataPropertyName = "TimerName";
            this.TimerName.HeaderText = "Name";
            this.TimerName.Name = "TimerName";
            this.TimerName.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(782, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pilots";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Not currently implemented!";
            // 
            // bChangeGliderScoreDirectory
            // 
            this.bChangeGliderScoreDirectory.AutoSize = true;
            this.bChangeGliderScoreDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bChangeGliderScoreDirectory.Location = new System.Drawing.Point(658, 50);
            this.bChangeGliderScoreDirectory.Name = "bChangeGliderScoreDirectory";
            this.bChangeGliderScoreDirectory.Size = new System.Drawing.Size(91, 34);
            this.bChangeGliderScoreDirectory.TabIndex = 4;
            this.bChangeGliderScoreDirectory.Text = "Browse";
            this.bChangeGliderScoreDirectory.UseVisualStyleBackColor = true;
            this.bChangeGliderScoreDirectory.Click += new System.EventHandler(this.bChangeGliderScoreDirectory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input zip:";
            // 
            // tbInputZipFile
            // 
            this.tbInputZipFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputZipFile.Location = new System.Drawing.Point(173, 10);
            this.tbInputZipFile.Name = "tbInputZipFile";
            this.tbInputZipFile.ReadOnly = true;
            this.tbInputZipFile.Size = new System.Drawing.Size(479, 29);
            this.tbInputZipFile.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output Directory:";
            // 
            // tbOutputGliderScoreDirectory
            // 
            this.tbOutputGliderScoreDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutputGliderScoreDirectory.Location = new System.Drawing.Point(173, 52);
            this.tbOutputGliderScoreDirectory.Name = "tbOutputGliderScoreDirectory";
            this.tbOutputGliderScoreDirectory.ReadOnly = true;
            this.tbOutputGliderScoreDirectory.Size = new System.Drawing.Size(479, 29);
            this.tbOutputGliderScoreDirectory.TabIndex = 9;
            // 
            // GliderScoreMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 580);
            this.Controls.Add(this.tbOutputGliderScoreDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInputZipFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bChangeGliderScoreDirectory);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bInputZipFile);
            this.Name = "GliderScoreMerge";
            this.Text = "GliderScoreMerge";
            this.Load += new System.EventHandler(this.GliderScoreMerge_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTimerNames)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bInputZipFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgTimerNames;
        private System.Windows.Forms.Button bChangeGliderScoreDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInputZipFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOutputGliderScoreDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checked;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimerName;
    }
}

