using Common.Service;
using Models;
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
        [Given(@"I have the following employee:")]
        public void GivenIHaveTheFollowingEmployee(Table table)
        {
            var eService = new EmployeeService();
            _employees = eService.CreateEmployee(table);
            
        }

        [When(@"I post employee to the api")]
        public void WhenIPostEmployeeToTheApi()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I verify that the request was successful")]
        public void ThenIVerifyThatTheRequestWasSuccessful()
        {
          //  ScenarioContext.Current.Pending();
        }

    }
}
