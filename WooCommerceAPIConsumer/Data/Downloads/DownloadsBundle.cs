using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCommerce.Data.Downloads
{
    using Newtonsoft.Json;

    internal class DownloadsBundle
    {
        [JsonProperty("downloads")]
        public IEnumerable<Download> Content { get; set; }
    }
}
