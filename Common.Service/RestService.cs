using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Service
{
    public class RestService
    {
        private RestClient _restClient;
       private RestRequest _restRequest;
       private IRestResponse _restResponse;

        public IRestResponse MakePostRequest(string jsonString, string url)
        {
            _restRequest = new RestRequest(Method.POST);
            _restRequest.AddHeader("Content-Type", "application/json");
            RestClient restClient = new RestClient(url);
            _restRequest.AddParameter("undefined", jsonString, ParameterType.RequestBody);
           return _restResponse = RestServiceHelper.Execute(restClient, _restRequest);
            
        }

        public IRestResponse DeleteEmployee(string id, string url)
        {
            _restRequest = new RestRequest(Method.DELETE);
            RestClient restClient = new RestClient($"{url}/{id}");
            _restRequest.AddParameter("undefined", ParameterType.UrlSegment);
            return _restResponse = RestServiceHelper.Execute(restClient, _restRequest);
        }






    }
}
