namespace FlappyBird
{
    partial class StartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.loader = new System.Windows.Forms.Timer(this.components);
            this.lblPercentageCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Loading...";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Teal;
            this.progressBar.Location = new System.Drawing.Point(75, 167);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(471, 41);
            this.progressBar.TabIndex = 1;
            this.progressBar.UseWaitCursor = true;
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(230, 259);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(162, 70);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Now";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // loader
            // 
            this.loader.Enabled = true;
            this.loader.Interval = 20;
            this.loader.Tick += new System.EventHandler(this.LoaderEvent);
            // 
            // lblPercentageCounter
            // 
            this.lblPercentageCounter.AutoSize = true;
            this.lblPercentageCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentageCounter.ForeColor = System.Drawing.Color.White;
            this.lblPercentageCounter.Location = new System.Drawing.Point(563, 174);
            this.lblPercentageCounter.Name = "lblPercentageCounter";
            this.lblPercentageCounter.Size = new System.Drawing.Size(27, 29);
            this.lblPercentageCounter.TabIndex = 3;
            this.lblPercentageCounter.Text = "0";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(653, 418);
            this.Controls.Add(this.lblPercentageCounter);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer loader;
        private System.Windows.Forms.Label lblPercentageCounter;
    }
}