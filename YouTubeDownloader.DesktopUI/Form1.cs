namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {
        VideoInfo? videoInfo = null;
        YoutubeFileType? youtubeFileType = null;

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();

        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private async void GetLinkVideoButtonClick(object sender, EventArgs e)
        {
            try
            {

                string? youtubeUrlStr = youtubeUrlTxt?.Text;

                string? typeSelected =
                    downloadSettingGroupBox?.Controls?.OfType<RadioButton>()?.FirstOrDefault(r => r.Checked)?.Text;

                var check = youtubeUrlStr?.Trim()?.Length > 0 && typeSelected?.Length > 0;

                if (check)
                {
                    videoInfo = null;
                    groupBoxVideoInfo.Visible = false;
                    loadVideoInfoSpinner.Visible = true;

                    if (typeSelected == "Audio (MP3 128 kbps)")
                    {
                        youtubeFileType = YoutubeFileType.AUDIO_MP3;
                    }

                    if (typeSelected == "Video (MP4 1080p)")
                    {
                        youtubeFileType = YoutubeFileType.VIDEO_MP4;
                    }

                    downloadSettingGroupBox.Enabled = false;

                    videoInfo = await Services.GetYoutubeFileInfo(youtubeUrlStr, youtubeFileType);
                    var ms = await Services.DownloadImageAsMemoryStream(videoInfo?.ImageURL);

                    Image image = Image.FromStream(ms, true);

                    imageUrlBox.Image = image;
                    groupBoxVideoInfo.Visible = true;
                    downloadSettingGroupBox.Enabled = true;
                    videoNameLabel.Text = videoInfo?.Title;
                    videoDescriptionLabel.Text = videoInfo?.Description;
                    videoTimeLabel.Text = videoInfo?.Time;

                    loadVideoInfoSpinner.Visible = false;
                    youtubeUrlTxt?.ResetText();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Sorry...Try Again! SERVER ERROR", "GetLinkVideo ERROR");
                loadVideoInfoSpinner.Visible = false;
                downloadSettingGroupBox.Enabled = true;
            }
        }

        private async void downloadBtnClick(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    downloadLabel.Visible = true;
                    downloadBtn.Enabled = false;
                    getLinkVideoButton.Enabled = false;
                    downloadSpinner.Visible = true;
                    downloadLabel.Text = "Downloading";

                    var imagelocation = dialog.SelectedPath;
                    await Services.DownloadYoutubeFile(videoInfo, imagelocation);

                    downloadLabel.Text = "Successfully downloaded file!";
                    downloadSpinner.Visible = false;

                    await Task.Delay(3000);

                    downloadLabel.Visible = false;
                    downloadBtn.Enabled = true;
                    downloadSettingGroupBox.Enabled = true;
                    groupBoxVideoInfo.Visible = false;
                    videoInfo = null;

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Sorry...Try Again! SERVER ERROR", "GetLinkVideo ERROR");
                loadVideoInfoSpinner.Visible = false;
                downloadSettingGroupBox.Enabled = true;
                getLinkVideoButton.Enabled = true;
            }
        }

        private void closeProgramClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}