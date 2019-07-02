using Common;
using Common.Service;
using Models;
using Models.Context;
using NUnit.Framework;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Specflow
{
    [Binding]
    public class Step_Definition
    {
        private readonly RequestContext _requestContext;
        private readonly ResponseContext _responseContext;

        public Step_Definition(RequestContext _requestContext, ResponseContext _responseContext)
        {
            this._requestContext = _requestContext;
            this._responseContext = _responseContext;
        }


        [Given(@"I have the following employees:")]
        public void GivenIHaveTheFollowingEmployee(Table table)
        {
            var eService = new EmployeeService();
            _requestContext.EmployeeModel = eService.CreateEmployee(table);            
        }

        [When(@"I add employees to the database")]
        public void AddEmployees()
        {
            var restService = new RestService();
            var helper = new StepDefinitionHelper();
            List<Employee> employees = new List<Employee>();
            
        }

        [Then(@"I delete employees from the database")]
        public void ThenIDeleteEmployeesFromTheDatabase()
        {
            var restService = new RestService();            
        }

    }
}
