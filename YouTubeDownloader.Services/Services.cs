using PuppeteerSharp;

namespace YoutubeDownloader
{
    public class Services
    {

        public static async Task<VideoInfo?> GetYoutubeFileInfo(string? youtubeURL, YoutubeFileType? youTubeFileType)
        {
            VideoInfo? videoInfo = null;
            Browser? browser = null;

            try
            {
                using var browserFetcher = new BrowserFetcher();
                await browserFetcher.DownloadAsync(BrowserFetcher.DefaultChromiumRevision);

                browser = await Puppeteer.LaunchAsync(new LaunchOptions
                {
                    Headless = true
                });

                var page = await browser.NewPageAsync();

                await page.GoToAsync("https://x2download.com/en96");
                await page.TypeAsync(".search__input", youtubeURL);

                var downloadButton = await page.QuerySelectorAsync(".search-form button");
                await downloadButton.ClickAsync();

                await page.WaitForTimeoutAsync(1000);

                var image = await page.QuerySelectorAllAsync("#search-result .detail .thumbnail img");
                var title = await page.QuerySelectorAllAsync("#search-result .detail .thumbnail .content .clearfix h3");
                var descriptions = await page.QuerySelectorAllAsync("#search-result .detail .thumbnail .content .clearfix p");

                var imageSrc = await image[0].GetPropertyAsync("src");
                var titleText = await title[0].GetPropertyAsync("innerText");
                var description = await descriptions[0].GetPropertyAsync("innerText");
                var time = await descriptions[1].GetPropertyAsync("innerText");

                string? imageUrl = (await imageSrc.JsonValueAsync())?.ToString();
                string? titleTextStr = (await titleText.JsonValueAsync())?.ToString();
                string? descriptionStr = (await description.JsonValueAsync())?.ToString();
                string? timeStr = (await time.JsonValueAsync())?.ToString();

                await page.WaitForTimeoutAsync(1000);

                videoInfo = new VideoInfo()
                {
                    ImageURL = imageUrl,
                    Title = titleTextStr,
                    Description = descriptionStr,
                    Time = timeStr,
                };

                var GetFileTypeInfo = Helpers.GetFileTypeInfo(youTubeFileType);

                string? fileType = GetFileTypeInfo.TypeString;

                await page.EvaluateExpressionAsync($"document.querySelectorAll('.content .clearfix .magT10 .flex #formatSelect option[data-format=\"{fileType}\"]')[0].selected = true");
                await page.WaitForTimeoutAsync(6000);

                var getLinkButton = await page.QuerySelectorAsync(".btn-ads");
                await getLinkButton.ClickAsync();

                await page.WaitForTimeoutAsync(1000);

                var downloadFileButton = await page.QuerySelectorAsync("#asuccess");

                await page.WaitForTimeoutAsync(1000);

                var urlToDownload = await downloadFileButton.GetPropertyAsync("href");
                var urlToDownloadJsonValue = await urlToDownload.JsonValueAsync();

                string? urlToDownloadStr = urlToDownloadJsonValue?.ToString();

                if (videoInfo != null)
                {
                    videoInfo.FileType = GetFileTypeInfo.FileType;
                    videoInfo.DownloadUrl = urlToDownloadStr;
                }

                await browser.CloseAsync();
            }
            catch (ArgumentException e)
            {
                browser?.CloseAsync();
                throw new ArgumentException(e.Message);
            }

            return videoInfo;
        }


        public static async Task DownloadYoutubeFile(VideoInfo? videoInfo, string? path)
        {
            try
            {

                string? fileType = Helpers.GetFileTypeInfo(videoInfo?.FileType)?.TypeString;

                using (var client = new HttpClient())
                {
                    Guid myuuid = Guid.NewGuid();
                    string fileId = myuuid.ToString();
                    var fileName = $"{fileId}.{fileType}";
                    var pathResult = $"{path}/{fileName}";

                    await client.DownloadFileTaskAsync(videoInfo?.DownloadUrl, pathResult);
                }
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException(e.Message);
            }

        }

        public static async Task<string> DownloadImageAsBase64(string? imageUrl)
        {
            string? imageBase64 = null;

            try
            {
                using (var client = new HttpClient())
                {
                    imageBase64 = await client.GetImageAsBase64(imageUrl);
                }

            }
            catch (ArgumentException e)
            {
                throw new ArgumentException(e.Message);
            }

            return imageBase64;

        }

        public static async Task<MemoryStream> DownloadImageAsMemoryStream(string? imageUrl)
        {
            MemoryStream? ms = null;

            try
            {
                string? base64Image = await DownloadImageAsBase64(imageUrl);

                byte[] imageBytes = Convert.FromBase64String(base64Image);
                ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                ms.Write(imageBytes, 0, imageBytes.Length);
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException(e.Message);
            }

            return ms;

        }
    }
}