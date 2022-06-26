namespace YoutubeDownloader
{
    public static class ExtensionUtility
    {
        public static async Task DownloadFileTaskAsync(this HttpClient client, string? uri, string FileName)
        {
            using (var s = await client.GetStreamAsync(uri))
            {
                using (var fs = new FileStream(FileName, FileMode.CreateNew))
                {
                    await s.CopyToAsync(fs);
                }
            }
        }

        public static async Task<string> GetImageAsBase64(this HttpClient client, string? url)
        {
            var bytes = await client.GetByteArrayAsync(url);
            return Convert.ToBase64String(bytes);
        }

        public static void map<T>(this IEnumerable<T> enumerable, Action<T, int> handler)
        {
            int idx = 0;
            foreach (T item in enumerable)
                handler(item, idx++);
        }
    }
}