using YoutubeDownloader;

namespace MyApp
{
    internal class ConsoleApp
    {
        static void Main(string[] args)
        {

            VideoInfo? videoInfo = null;

            Task.Run(async () =>
            {
                var videoUrl = "https://youtu.be/6GS52EfsAEc";
                var path = "I:/Download";

                videoInfo = await Services.GetYoutubeFileInfo(videoUrl, YoutubeFileType.VIDEO_MP4);

                await Services.DownloadYoutubeFile(videoInfo, path);

                Console.WriteLine("Title: {0}", videoInfo?.Title);
                Console.WriteLine("Description: {0}", videoInfo?.Description);
                Console.WriteLine("Time: {0}", videoInfo?.Time);
                Console.WriteLine("DownloadUrl: {0}", videoInfo?.DownloadUrl);

            }).Wait();

            Console.WriteLine("Video downloaded!");
            Console.ReadKey();
        }



    }
}