using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Logic
{
    public class EmployeeLogic:ILogic<Employee>
    {
        private List<Employee> employees = new List<Employee>()
            {
            new Employee()
            {
                Id=1,FirstName="FirstName1",LastName="LastName1",JobTitle="Title1",AddressOfResidence="A",DepartmentId=1
            },
            new Employee()
            {
                Id=2,FirstName="FirstName2",LastName="LastName2",JobTitle="Title2",AddressOfResidence="B",DepartmentId=2
            },
            new Employee()
            {
                Id=3,FirstName="FirstName3",LastName="LastName3",JobTitle="Title3",AddressOfResidence="C",DepartmentId=3
            },
            new Employee()
            {
                Id=4,FirstName="FirstName4",LastName="LastName4",JobTitle="Title4",AddressOfResidence="D",DepartmentId=1
            },
            new Employee()
            {
                Id=5,FirstName="FirstName5",LastName="LastName5",JobTitle="Title5",AddressOfResidence="E",DepartmentId=5
            }
        };

        public List<Employee> GetDepartmentList()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployeeList()
        {
            return this.employees;
        }
    }
}
