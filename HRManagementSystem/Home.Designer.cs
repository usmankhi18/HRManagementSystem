namespace HRManagementSystem
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recruitmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recruiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testTimingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recruitmentToolStripMenuItem,
            this.applicantsToolStripMenuItem,
            this.recruiterToolStripMenuItem,
            this.testTimingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recruitmentToolStripMenuItem
            // 
            this.recruitmentToolStripMenuItem.Name = "recruitmentToolStripMenuItem";
            this.recruitmentToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.recruitmentToolStripMenuItem.Text = "Recruitment";
            this.recruitmentToolStripMenuItem.Click += new System.EventHandler(this.recruitmentToolStripMenuItem_Click);
            // 
            // applicantsToolStripMenuItem
            // 
            this.applicantsToolStripMenuItem.Name = "applicantsToolStripMenuItem";
            this.applicantsToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.applicantsToolStripMenuItem.Text = "Applicants";
            this.applicantsToolStripMenuItem.Click += new System.EventHandler(this.applicantsToolStripMenuItem_Click);
            // 
            // recruiterToolStripMenuItem
            // 
            this.recruiterToolStripMenuItem.Name = "recruiterToolStripMenuItem";
            this.recruiterToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.recruiterToolStripMenuItem.Text = "Recruiter";
            this.recruiterToolStripMenuItem.Click += new System.EventHandler(this.recruiterToolStripMenuItem_Click);
            // 
            // testTimingToolStripMenuItem
            // 
            this.testTimingToolStripMenuItem.Name = "testTimingToolStripMenuItem";
            this.testTimingToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.testTimingToolStripMenuItem.Text = "Test Timing";
            this.testTimingToolStripMenuItem.Click += new System.EventHandler(this.testTimingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HRManagementSystem.Properties.Resources.kashipara;
            this.pictureBox1.Location = new System.Drawing.Point(481, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recruitmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recruiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testTimingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}