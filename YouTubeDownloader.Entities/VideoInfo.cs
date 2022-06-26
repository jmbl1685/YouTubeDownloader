namespace YoutubeDownloader
{
    public class VideoInfo
    {
        public string? ImageURL { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Time { get; set; }
        public string? DownloadUrl { get; set; }
        public YoutubeFileType? FileType { get; set; }
    }
}