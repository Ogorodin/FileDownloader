using AltoHttp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDownloader
{
    public partial class Form1 : Form
    {

        HttpDownloader _httpDownloader;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _httpDownloader = new HttpDownloader(txtBoxUrl.Text, $"{Application.StartupPath }\\{Path.GetFileName(txtBoxUrl.Text)}");
            _httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
            _httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
            _httpDownloader.Start();
        }

        private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                lblProgress.Text = "Finish!";
                lblPercent.Text = "100%";
            });
        }

        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            progressBar.Value = (int)e.Progress;
            lblPercent.Text = $"{e.Progress.ToString("0.00")} %";
            lblSpeedDisplay.Text = string.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
            lblMBDownloaded.Text = string.Format("{0} MB/s", (_httpDownloader.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
            lblStatus.Text = "Downloading ...";
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (_httpDownloader != null)
                _httpDownloader.Pause();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            if (_httpDownloader != null)
                _httpDownloader.Resume();
        }
    }
}
