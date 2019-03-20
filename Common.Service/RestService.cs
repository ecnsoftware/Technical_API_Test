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

        public IRestResponse MakePostRequest(string jsonString)
        {
            _restRequest = new RestRequest(Method.POST);
            RestClient restClient = new RestClient(EndPoints.CreateEmployeeEndpoint);
            _restRequest.AddParameter("undefined", jsonString, ParameterType.RequestBody);
           return _restResponse = RestServiceHelper.Execute(restClient, _restRequest);
            
        }






    }
}
