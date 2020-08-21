using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Models
{
    public class Employee
    {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string JobTitle { get; set; }
            public string AddressOfResidence { get; set; }
            [ForeignKey("DepartmentId")]
            [NotMapped]
            public Department Departments;
            public int DepartmentId { get; set; }
    }
}
