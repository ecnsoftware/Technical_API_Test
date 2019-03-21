using Common.Service;
using Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow
{
   public class StepDefinitionHelper
    {
        public T DeserializeJsonToObject<T>(IRestResponse response)
        {
            if (response.IsSuccessful && !response.Content.Contains("error"))
            {
                return RestServiceHelper.DeserializeJson<T>(response.Content);
            }
            else
            {
                throw new Exception($"Something went wrong! {response.Content}");
            }
        }
    }
}
