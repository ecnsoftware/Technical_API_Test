using Common.Service;
using Models;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Specflow
{
    [Binding]
    public class Step_Definition
    {
        private static IEnumerable<Employee> _employees;
        private static bool isSuccessfull;

        [Given(@"I have the following employee:")]
        public void GivenIHaveTheFollowingEmployee(Table table)
        {
            var eService = new EmployeeService();
            _employees = eService.CreateEmployee(table);
            
        }

        [When(@"I post employee to the api")]
        public void WhenIPostEmployeeToTheApi()
        {
            var restService = new RestService();
            var helper = new StepDefinitionHelper();
            foreach (var emp in _employees)
             {
               var deserialized = helper.DeserializeJsonToObject<Employee>(restService.MakePostRequest(RestServiceHelper.BuildJsonObject(emp)));
               var response = restService.DeleteEmployee(deserialized.Id);
                isSuccessfull = response.IsSuccessful;

            }
            
        }

        [Then(@"I verify that the request was successful")]
        public void ThenIVerifyThatTheRequestWasSuccessful()
        {
            Assert.That(isSuccessfull);
        }

    }
}
