using Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Service
{
   public static class RestServiceHelper
    {
        public static string BuildJsonObject<T>(T obj) 
            => JsonConvert.SerializeObject(obj);

        public  static IRestResponse Execute(RestClient restClient, RestRequest restRequest)
            => restClient.Execute(restRequest);

        public static T DeserializeJson<T>( string response) 
            => JsonConvert.DeserializeObject<T>(response);
        
    }
}
