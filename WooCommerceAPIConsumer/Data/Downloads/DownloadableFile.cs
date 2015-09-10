namespace SharpCommerce.Data.Downloads
{
    using Newtonsoft.Json;

    public class DownloadableFile
    {
        /// <summary>
        /// File ID (file md5 hash) [read-only]
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// File name
        /// </summary>
        [JsonProperty("name")]
        public string FileName { get; set; }

        /// <summary>
        /// File URL. In write-mode you can use this property to send new files
        /// </summary>
        [JsonProperty("file")]
        public string Url { get; set; }
    }
}
