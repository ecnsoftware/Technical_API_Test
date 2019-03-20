using Models;
using System;
using Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Common.Service
{
   public class EmployeeService
    {
        public IEnumerable<Employee>CreateEmployee(Table table)
        {
            var employees = new List<Employee>();
            foreach (var row in table.Rows)
            {
                employees.Add(new Employee
                {
                    Id = Int32.Parse(row["Id"]),
                    FullName = row["FullName"],
                    Salary = Int32.Parse(row["Salary"]),
                    Age = Int32.Parse(row["Age"])

                });             

            }
            return employees;
        }
       
    }
}
