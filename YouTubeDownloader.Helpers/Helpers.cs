namespace YoutubeDownloader
{
    public static class Helpers
    {

        public static FileTypeInfo GetFileTypeInfo(YoutubeFileType? youTubeFileType)
        {
            FileTypeInfo fileTypeInfo = new FileTypeInfo();

            try
            {

                if (YoutubeFileType.AUDIO_MP3 == youTubeFileType)
                {
                    fileTypeInfo.TypeString = "mp3";
                    fileTypeInfo.FileType = YoutubeFileType.AUDIO_MP3;
                }

                if (YoutubeFileType.VIDEO_MP4 == youTubeFileType)
                {
                    fileTypeInfo.TypeString = "mp4";
                    fileTypeInfo.FileType = YoutubeFileType.VIDEO_MP4;
                }

            }
            catch (ArgumentException e)
            {
                throw new ArgumentException(e.Message);
            }

            return fileTypeInfo;
        }
    }
}