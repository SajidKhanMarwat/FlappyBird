namespace FlappyBird
{
    partial class Close
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
            this.pbRestart = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRestart
            // 
            this.pbRestart.Image = global::FlappyBird.Properties.Resources.restartPNG;
            this.pbRestart.Location = new System.Drawing.Point(225, 86);
            this.pbRestart.Name = "pbRestart";
            this.pbRestart.Size = new System.Drawing.Size(92, 80);
            this.pbRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRestart.TabIndex = 1;
            this.pbRestart.TabStop = false;
            this.pbRestart.Click += new System.EventHandler(this.pbRestart_Click);
            // 
            // pbExit
            // 
            this.pbExit.Image = global::FlappyBird.Properties.Resources.exitPNG;
            this.pbExit.Location = new System.Drawing.Point(39, 77);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(115, 99);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 0;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // Close
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(355, 237);
            this.Controls.Add(this.pbRestart);
            this.Controls.Add(this.pbExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Close";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Close";
            ((System.ComponentModel.ISupportInitialize)(this.pbRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbRestart;
    }
}