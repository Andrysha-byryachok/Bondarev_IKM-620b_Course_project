namespace Bondarev_IKM_620b_Course_project
{
    partial class About
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
            this.components = new System.ComponentModel.Container();
            this.LbIAndProject = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.tAbout = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // LbIAndProject
            // 
            this.LbIAndProject.AutoSize = true;
            this.LbIAndProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbIAndProject.Location = new System.Drawing.Point(158, 32);
            this.LbIAndProject.Name = "LbIAndProject";
            this.LbIAndProject.Size = new System.Drawing.Size(521, 210);
            this.LbIAndProject.TabIndex = 0;
            this.LbIAndProject.Text = "Розробив курсовий проект\r\nСтудент ІКМ 620-Б \r\nБондарев Андрій Сергійович\r\nТекст з" +
    "авдання :\r\nТекст\r\n";
            this.LbIAndProject.Click += new System.EventHandler(this.LbIAndProject_Click);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(329, 316);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 1;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // tAbout
            // 
            this.tAbout.Enabled = true;
            this.tAbout.Tick += new System.EventHandler(this.tAbout_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 379);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.LbIAndProject);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbIAndProject;
        private System.Windows.Forms.Button bClose;
        public System.Windows.Forms.Timer tAbout;
        public System.Windows.Forms.ProgressBar progressBar1;
    }
}