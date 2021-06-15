
namespace FileDownloader
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtBoxUrl = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblDownloaded = new System.Windows.Forms.Label();
            this.lblMBDownloaded = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblSpeedDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(537, 147);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(632, 147);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(77, 30);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "&Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(715, 147);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(75, 30);
            this.btnResume.TabIndex = 2;
            this.btnResume.Text = "&Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(37, 30);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(30, 17);
            this.lblUrl.TabIndex = 3;
            this.lblUrl.Text = "Url:";
            // 
            // txtBoxUrl
            // 
            this.txtBoxUrl.Location = new System.Drawing.Point(84, 27);
            this.txtBoxUrl.Name = "txtBoxUrl";
            this.txtBoxUrl.Size = new System.Drawing.Size(706, 22);
            this.txtBoxUrl.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(37, 67);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status:";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(108, 67);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(32, 17);
            this.lblProgress.TabIndex = 7;
            this.lblProgress.Text = "???";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(753, 82);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(28, 17);
            this.lblPercent.TabIndex = 8;
            this.lblPercent.Text = "0%";
            // 
            // lblDownloaded
            // 
            this.lblDownloaded.AutoSize = true;
            this.lblDownloaded.Location = new System.Drawing.Point(37, 188);
            this.lblDownloaded.Name = "lblDownloaded";
            this.lblDownloaded.Size = new System.Drawing.Size(90, 17);
            this.lblDownloaded.TabIndex = 9;
            this.lblDownloaded.Text = "Downloaded:";
            // 
            // lblMBDownloaded
            // 
            this.lblMBDownloaded.AutoSize = true;
            this.lblMBDownloaded.Location = new System.Drawing.Point(133, 188);
            this.lblMBDownloaded.Name = "lblMBDownloaded";
            this.lblMBDownloaded.Size = new System.Drawing.Size(40, 17);
            this.lblMBDownloaded.TabIndex = 10;
            this.lblMBDownloaded.Text = "0 MB";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(84, 112);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(706, 23);
            this.progressBar.TabIndex = 11;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(37, 220);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(53, 17);
            this.lblSpeed.TabIndex = 12;
            this.lblSpeed.Text = "Speed:";
            // 
            // lblSpeedDisplay
            // 
            this.lblSpeedDisplay.AutoSize = true;
            this.lblSpeedDisplay.Location = new System.Drawing.Point(133, 220);
            this.lblSpeedDisplay.Name = "lblSpeedDisplay";
            this.lblSpeedDisplay.Size = new System.Drawing.Size(51, 17);
            this.lblSpeedDisplay.TabIndex = 13;
            this.lblSpeedDisplay.Text = "0 MB/s";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 267);
            this.Controls.Add(this.lblSpeedDisplay);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblMBDownloaded);
            this.Controls.Add(this.lblDownloaded);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtBoxUrl);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "File download...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtBoxUrl;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblDownloaded;
        private System.Windows.Forms.Label lblMBDownloaded;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblSpeedDisplay;
    }
}

