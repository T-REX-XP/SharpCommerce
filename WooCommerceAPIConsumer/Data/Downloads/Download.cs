using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCommerce.Data.Downloads
{
    using Newtonsoft.Json;

    public class Download
    {
        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("download_id")]
        public string DownloadId { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("download_name")]
        public string DownloadableFileName { get; set; }

        [JsonProperty("order_id")]
        public int OrderId { get; set; }

        [JsonProperty("order_key")]
        public string OrderKey { get; set; }

        [JsonProperty("downloads_remaining")]
        public int? DownloadsRemaining { get; set; }

        [JsonProperty("access_expires")]
        public DateTime? AccessExpires { get; set; }

        [JsonProperty("file")]
        public DownloadableFile[] File { get; set; }
    }
}
