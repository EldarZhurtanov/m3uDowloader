using System;
using System.ComponentModel;
using System.Windows.Forms;
using m3uDownload.DLL;

namespace m3uDownload.UI
{
    public partial class Form : System.Windows.Forms.Form
    {
        Downloader downloader = new Downloader();

        public Form()
        {
            InitializeComponent();
        }

        private void CopyrightLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/nedoche_love_k");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            playlistPath.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            DirPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(DirPath.Text == string.Empty || playlistPath.Text == string.Empty)
            {
                notifyIcon1.BalloonTipText = "Проверьте правильность введённых данных";
                notifyIcon1.BalloonTipTitle = "Ошибка!";
                notifyIcon1.ShowBalloonTip(5000);
                return;
            }
            button3.Enabled = false;

            try
            {
                downloader.M3uPlaylistPath = playlistPath.Text;
                downloader.SaveDirectory = DirPath.Text;
                downloader.CountOfParallelDownload = Convert.ToUInt32(CntOfParallelDonload.Value);
                downloader.NumberInTheTitle = CheckNumerInTitle.Checked;
                downloader.NumberInTheTag = CheckNumberInTag.Checked;
                downloader.DownloadOneSongCompleted += DownloadOneSongCompleted;
                progressBar1.Maximum = Convert.ToInt32(downloader.CountOfTrackOnPlaylist);
                DownLabel.Text = "0 из " + downloader.CountOfTrackOnPlaylist;
                downloader.AsyncDownload();
            }
            catch(Exception ex)
            {
                notifyIcon1.BalloonTipTitle = "Исключение!";
                notifyIcon1.BalloonTipText = "(кинь плес по автору) " + ex.Message;
            }
        }

        void DownloadOneSongCompleted(object sender, AsyncCompletedEventArgs e)
        {
            progressBar1.Value++;
            DownLabel.Text = progressBar1.Value + " из " + progressBar1.Maximum;
            if(progressBar1.Value == progressBar1.Maximum)
            {
                DownloadAllSongCompleted();
            }
        }

        void DownloadAllSongCompleted()
        {
            progressBar1.Value = 0;
            notifyIcon1.BalloonTipText = progressBar1.Maximum + " песен загружено";
            notifyIcon1.BalloonTipTitle = "Готово!";
            notifyIcon1.ShowBalloonTip(5000);
            downloader.SetDefaultSettings();
            button3.Enabled = true;
        }
    }
}
