using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCommerce.Data.Coupons
{
    using Newtonsoft.Json;

    internal class CouponsBundle
    {
        [JsonProperty("coupons")]
        public IEnumerable<Coupon> Content { get; set; }
    }
}
