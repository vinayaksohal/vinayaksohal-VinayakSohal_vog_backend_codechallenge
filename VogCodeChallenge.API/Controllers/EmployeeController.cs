using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VogCodeChallenge.API.Models;
using VogCodeChallenge.API.VogContext;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VogCodeChallenge.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataRepository<Employee> _IContext;
        public EmployeeController(IDataRepository<Employee> iContext)
        {
            this._IContext = iContext;
        }
        // GET: api/employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return this._IContext.GetAll();
        }

        [HttpGet("department/{id}")]
        public IEnumerable<Employee> GetByDepartment(int id)
        {
            return this._IContext.ListAll(emp => emp.DepartmentId == id);
        }
        // POST api/employee
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/Employee/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
