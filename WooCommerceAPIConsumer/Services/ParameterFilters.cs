using System;
using System.Collections.Generic;

namespace SharpCommerce.Services
{
    using System.Globalization;
    using System.Web;

    public static class ParameterFilters
    {
        public static void AddFilterCreatedAtMin(this Dictionary<string, string> parameters, DateTime date)
        {
            parameters.Add("filter[created_at_min]", date.ToString("yyyy-mm-dd"));
        }

        public static void AddFilterCreatedAtMax(this Dictionary<string, string> parameters, DateTime date)
        {
            parameters.Add("filter[created_at_max]", date.ToString("yyyy-mm-dd"));
        }

        public static void AddFilterUpdatedAtMin(this Dictionary<string, string> parameters, DateTime date)
        {
            parameters.Add("filter[updated_at_min]", date.ToString("yyyy-mm-dd"));
        }

        public static void AddFilterUpdatedAtMax(this Dictionary<string, string> parameters, DateTime date)
        {
            parameters.Add("filter[updated_at_max]", date.ToString("yyyy-mm-dd"));
        }

        public static void AddFilterKeyword(this Dictionary<string, string> parameters, string keyword)
        {
            parameters.Add("filter[q]", HttpUtility.UrlEncode(keyword));
        }

        public static void AddFilterOrderAscending(this Dictionary<string, string> parameters)
        {
            parameters.Add("filter[order]", "ASC");
        }
        
        public static void AddFilterOrderDescending(this Dictionary<string, string> parameters)
        {
            parameters.Add("filter[order]", "DESC");
        }

        // see http://codex.wordpress.org/Class_Reference/WP_Query#Order_.26_Orderby_Parameters
        // Defaults to 'date'
        // You can order by 'meta_value' but you must provide 'orderby_meta_key'
        public static void AddFilterOrderBy(this Dictionary<string, string> parameters, string parameter)
        {
            parameters.Add("filter[orderby]", parameter);
        }

        public static void AddFilterOrderByMetaKey(this Dictionary<string, string> parameters, string key)
        {
            parameters.Add("filter[orderby_meta_key]", key);
        }

        public static void AddFilterPostStatus(this Dictionary<string, string> parameters, string status)
        {
            parameters.Add("filter[post_status]", status);
        }

        public static void AddFilterMeta(this Dictionary<string, string> parameters)
        {
            parameters.Add("filter[meta]", "true");
        }

        public static void AddFilterLimit(this Dictionary<string, string> parameters, int itemsPerPage)
        {
            parameters.Add("filter[limit]", itemsPerPage.ToString(CultureInfo.InvariantCulture));
        }

        public static void AddFieldLimiter(this Dictionary<string, string> parameters, string fieldsToInclude)
        {
            parameters.Add("fields", fieldsToInclude);
        }

        public static void SetPageNumber(this Dictionary<string, string> parameters, int pageNumber)
        {
            parameters.Add("page", pageNumber.ToString(CultureInfo.InvariantCulture));
        }

        public static void AddFilterOffset(this Dictionary<string, string> parameters, int offset)
        {
            parameters.Add("filter[offset]", offset.ToString(CultureInfo.InvariantCulture));
        }

        // For Orders
        public static void AddFilterStatus(this Dictionary<string, string> parameters, string status)
        {
            parameters.Add("filter[status]", status);
        }

        // For 'View Customers Count' [customer | subscriber]
        public static void AddFilterRole(this Dictionary<string, string> parameters, string role)
        {
            parameters.Add("filter[role]", role);
        }



        // For 'View List of Products' Products by type. eg: simple or variable
        public static void AddFilterProductType(this Dictionary<string, string> parameters, string type)
        {
            parameters.Add("filter[type]", type);
        }

        // For 'View List of Products'
        public static void AddFilterProductCategory(this Dictionary<string, string> parameters, string category)
        {
            parameters.Add("filter[category]", category);
        }        
        
        // For 'View List of Products'
        public static void AddFilterProductSku(this Dictionary<string, string> parameters, string sku)
        {
            parameters.Add("filter[sku]", sku);
        }
    }

}
