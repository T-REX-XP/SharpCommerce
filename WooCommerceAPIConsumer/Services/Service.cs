using System;

namespace SharpCommerce.Services
{
    using System.Collections.Generic;
    using System.Data.SqlTypes;

    using Newtonsoft.Json;
    using SharpCommerce.Web;

    public abstract class Service
    {
        protected readonly WoocommerceApiDriver ApiDriver;

        protected Service(WoocommerceApiDriver apiDriver)
        {
            ApiDriver = apiDriver;
        }

        protected T Post<T>(string apiEndpoint, Dictionary<string, string> parameters = null, T toSerialize = default(T))
        {
            var jsonData = JsonConvert.SerializeObject(toSerialize);
            var jsonResult = ApiDriver.Post(apiEndpoint, parameters, jsonData);
            return JsonConvert.DeserializeObject<T>(jsonResult);
        }

        protected T Put<T>(string apiEndpoint, Dictionary<string, string> parameters = null, T toSerialize = default(T))
        {
            var jsonData = JsonConvert.SerializeObject(toSerialize);
            var jsonResult = ApiDriver.Put(apiEndpoint, parameters, jsonData);
            return JsonConvert.DeserializeObject<T>(jsonResult);
        }

        protected T Delete<T>(string apiEndpoint, Dictionary<string, string> parameters = null)
        {
            var jsonResult = ApiDriver.Delete(apiEndpoint, parameters);
            return JsonConvert.DeserializeObject<T>(jsonResult);
        }

        protected T Get<T>(string apiEndpoint, Dictionary<string, string> parameters = null)
        {
            var jsonResult = ApiDriver.Get(apiEndpoint, parameters);
            return JsonConvert.DeserializeObject<T>(jsonResult);
        }
    }
}
