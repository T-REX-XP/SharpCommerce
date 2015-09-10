using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCommerce.Data.Products
{
    using Newtonsoft.Json;

    public class ProductCategory
    {
        //private readonly int id;
        //private readonly string name;
        //private readonly string slug;
        //private readonly int parent;
        //private readonly string description;
        //private readonly string display;
        //private readonly string image;
        //private readonly bool showCount;

        /// <summary>
        /// Category ID (term ID) read-only
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Category name read-only
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Category slug read-only
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Category parent read-only
        /// </summary>
        [JsonProperty("parent")]
        public int Parent { get; set; }

        /// <summary>
        /// Category description read-only
        /// </summary>
        [JsonProperty("description")]
        public string Descripton { get; set; }

        /// <summary>
        /// Category archive display type, the types available include: default, products, subcategories and both read-only
        /// </summary>
        [JsonProperty("display")]
        public string Display { get; set; }

        /// <summary>
        /// Category image URL read-only
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Shows the quantity of products in this category 
        /// </summary>
        [JsonProperty("count")]
        public bool ShowCount { get; set; }
    }
}
