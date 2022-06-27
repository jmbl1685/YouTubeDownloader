namespace YoutubeDownloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.downloadSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.getLinkVideoButton = new System.Windows.Forms.Button();
            this.videoTypeRadioBtn = new System.Windows.Forms.RadioButton();
            this.audioTypeRadioBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.youtubeUrlTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxVideoInfo = new System.Windows.Forms.GroupBox();
            this.downloadLabel = new System.Windows.Forms.Label();
            this.downloadSpinner = new System.Windows.Forms.PictureBox();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.videoTimeLabel = new System.Windows.Forms.Label();
            this.videoDescriptionLabel = new System.Windows.Forms.Label();
            this.videoNameLabel = new System.Windows.Forms.Label();
            this.imageUrlBox = new System.Windows.Forms.PictureBox();
            this.loadVideoInfoSpinner = new System.Windows.Forms.PictureBox();
            this.closeProgram = new System.Windows.Forms.PictureBox();
            this.downloadSettingGroupBox.SuspendLayout();
            this.groupBoxVideoInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downloadSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUrlBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadVideoInfoSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeProgram)).BeginInit();
            this.SuspendLayout();
            // 
            // downloadSettingGroupBox
            // 
            this.downloadSettingGroupBox.Controls.Add(this.getLinkVideoButton);
            this.downloadSettingGroupBox.Controls.Add(this.videoTypeRadioBtn);
            this.downloadSettingGroupBox.Controls.Add(this.audioTypeRadioBtn);
            this.downloadSettingGroupBox.Controls.Add(this.label2);
            this.downloadSettingGroupBox.Controls.Add(this.youtubeUrlTxt);
            this.downloadSettingGroupBox.Controls.Add(this.label1);
            this.downloadSettingGroupBox.Location = new System.Drawing.Point(21, 40);
            this.downloadSettingGroupBox.Name = "downloadSettingGroupBox";
            this.downloadSettingGroupBox.Size = new System.Drawing.Size(762, 177);
            this.downloadSettingGroupBox.TabIndex = 0;
            this.downloadSettingGroupBox.TabStop = false;
            this.downloadSettingGroupBox.Text = "Download Settings";
            // 
            // getLinkVideoButton
            // 
            this.getLinkVideoButton.Location = new System.Drawing.Point(604, 143);
            this.getLinkVideoButton.Name = "getLinkVideoButton";
            this.getLinkVideoButton.Size = new System.Drawing.Size(152, 23);
            this.getLinkVideoButton.TabIndex = 5;
            this.getLinkVideoButton.Text = "Get Link Video";
            this.getLinkVideoButton.UseVisualStyleBackColor = true;
            this.getLinkVideoButton.Click += new System.EventHandler(this.GetLinkVideoButtonClick);
            // 
            // videoTypeRadioBtn
            // 
            this.videoTypeRadioBtn.AutoSize = true;
            this.videoTypeRadioBtn.Location = new System.Drawing.Point(189, 112);
            this.videoTypeRadioBtn.Name = "videoTypeRadioBtn";
            this.videoTypeRadioBtn.Size = new System.Drawing.Size(128, 19);
            this.videoTypeRadioBtn.TabIndex = 4;
            this.videoTypeRadioBtn.TabStop = true;
            this.videoTypeRadioBtn.Text = "Video (MP4 1080p)";
            this.videoTypeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // audioTypeRadioBtn
            // 
            this.audioTypeRadioBtn.AutoSize = true;
            this.audioTypeRadioBtn.Location = new System.Drawing.Point(32, 112);
            this.audioTypeRadioBtn.Name = "audioTypeRadioBtn";
            this.audioTypeRadioBtn.Size = new System.Drawing.Size(143, 19);
            this.audioTypeRadioBtn.TabIndex = 3;
            this.audioTypeRadioBtn.TabStop = true;
            this.audioTypeRadioBtn.Text = "Audio (MP3 128 kbps)";
            this.audioTypeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Type";
            // 
            // youtubeUrlTxt
            // 
            this.youtubeUrlTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.youtubeUrlTxt.Location = new System.Drawing.Point(32, 52);
            this.youtubeUrlTxt.Name = "youtubeUrlTxt";
            this.youtubeUrlTxt.Size = new System.Drawing.Size(594, 23);
            this.youtubeUrlTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = " Paste YouTube link here ";
            // 
            // groupBoxVideoInfo
            // 
            this.groupBoxVideoInfo.Controls.Add(this.downloadLabel);
            this.groupBoxVideoInfo.Controls.Add(this.downloadSpinner);
            this.groupBoxVideoInfo.Controls.Add(this.downloadBtn);
            this.groupBoxVideoInfo.Controls.Add(this.videoTimeLabel);
            this.groupBoxVideoInfo.Controls.Add(this.videoDescriptionLabel);
            this.groupBoxVideoInfo.Controls.Add(this.videoNameLabel);
            this.groupBoxVideoInfo.Controls.Add(this.imageUrlBox);
            this.groupBoxVideoInfo.Location = new System.Drawing.Point(21, 228);
            this.groupBoxVideoInfo.Name = "groupBoxVideoInfo";
            this.groupBoxVideoInfo.Size = new System.Drawing.Size(762, 421);
            this.groupBoxVideoInfo.TabIndex = 1;
            this.groupBoxVideoInfo.TabStop = false;
            this.groupBoxVideoInfo.Visible = false;
            // 
            // downloadLabel
            // 
            this.downloadLabel.AutoSize = true;
            this.downloadLabel.Location = new System.Drawing.Point(539, 168);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(79, 15);
            this.downloadLabel.TabIndex = 6;
            this.downloadLabel.Text = "Downloading";
            this.downloadLabel.Visible = false;
            // 
            // downloadSpinner
            // 
            this.downloadSpinner.Image = global::YouTubeDownloader.DesktopUI.Properties.Resources.loader;
            this.downloadSpinner.Location = new System.Drawing.Point(563, 130);
            this.downloadSpinner.Name = "downloadSpinner";
            this.downloadSpinner.Size = new System.Drawing.Size(33, 33);
            this.downloadSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.downloadSpinner.TabIndex = 5;
            this.downloadSpinner.TabStop = false;
            this.downloadSpinner.Visible = false;
            // 
            // downloadBtn
            // 
            this.downloadBtn.Location = new System.Drawing.Point(52, 377);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(75, 23);
            this.downloadBtn.TabIndex = 4;
            this.downloadBtn.Text = "Download";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtnClick);
            // 
            // videoTimeLabel
            // 
            this.videoTimeLabel.AutoSize = true;
            this.videoTimeLabel.Location = new System.Drawing.Point(52, 339);
            this.videoTimeLabel.Name = "videoTimeLabel";
            this.videoTimeLabel.Size = new System.Drawing.Size(111, 15);
            this.videoTimeLabel.TabIndex = 3;
            this.videoTimeLabel.Text = "Sample Video Time";
            // 
            // videoDescriptionLabel
            // 
            this.videoDescriptionLabel.AutoSize = true;
            this.videoDescriptionLabel.Location = new System.Drawing.Point(52, 310);
            this.videoDescriptionLabel.Name = "videoDescriptionLabel";
            this.videoDescriptionLabel.Size = new System.Drawing.Size(145, 15);
            this.videoDescriptionLabel.TabIndex = 2;
            this.videoDescriptionLabel.Text = "Sample Video Description";
            // 
            // videoNameLabel
            // 
            this.videoNameLabel.AutoSize = true;
            this.videoNameLabel.Location = new System.Drawing.Point(52, 284);
            this.videoNameLabel.Name = "videoNameLabel";
            this.videoNameLabel.Size = new System.Drawing.Size(116, 15);
            this.videoNameLabel.TabIndex = 1;
            this.videoNameLabel.Text = "Sample Video Name";
            // 
            // imageUrlBox
            // 
            this.imageUrlBox.Location = new System.Drawing.Point(52, 27);
            this.imageUrlBox.Name = "imageUrlBox";
            this.imageUrlBox.Size = new System.Drawing.Size(364, 241);
            this.imageUrlBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageUrlBox.TabIndex = 0;
            this.imageUrlBox.TabStop = false;
            // 
            // loadVideoInfoSpinner
            // 
            this.loadVideoInfoSpinner.Image = global::YouTubeDownloader.DesktopUI.Properties.Resources.loader;
            this.loadVideoInfoSpinner.Location = new System.Drawing.Point(376, 372);
            this.loadVideoInfoSpinner.Name = "loadVideoInfoSpinner";
            this.loadVideoInfoSpinner.Size = new System.Drawing.Size(43, 41);
            this.loadVideoInfoSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadVideoInfoSpinner.TabIndex = 2;
            this.loadVideoInfoSpinner.TabStop = false;
            this.loadVideoInfoSpinner.Visible = false;
            // 
            // closeProgram
            // 
            this.closeProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeProgram.Image = global::YouTubeDownloader.DesktopUI.Properties.Resources.close;
            this.closeProgram.Location = new System.Drawing.Point(769, 12);
            this.closeProgram.Name = "closeProgram";
            this.closeProgram.Size = new System.Drawing.Size(19, 19);
            this.closeProgram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeProgram.TabIndex = 3;
            this.closeProgram.TabStop = false;
            this.closeProgram.Click += new System.EventHandler(this.closeProgramClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.closeProgram);
            this.Controls.Add(this.groupBoxVideoInfo);
            this.Controls.Add(this.downloadSettingGroupBox);
            this.Controls.Add(this.loadVideoInfoSpinner);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "YouTube Downloader";
            this.downloadSettingGroupBox.ResumeLayout(false);
            this.downloadSettingGroupBox.PerformLayout();
            this.groupBoxVideoInfo.ResumeLayout(false);
            this.groupBoxVideoInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downloadSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUrlBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadVideoInfoSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeProgram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox downloadSettingGroupBox;
        private Label label1;
        private TextBox youtubeUrlTxt;
        private RadioButton videoTypeRadioBtn;
        private RadioButton audioTypeRadioBtn;
        private Label label2;
        private Button getLinkVideoButton;
        private GroupBox groupBoxVideoInfo;
        private PictureBox imageUrlBox;
        private Button downloadBtn;
        private Label videoTimeLabel;
        private Label videoDescriptionLabel;
        private Label videoNameLabel;
        private PictureBox loadVideoInfoSpinner;
        private PictureBox downloadSpinner;
        private Label downloadLabel;
        private PictureBox closeProgram;
    }
}