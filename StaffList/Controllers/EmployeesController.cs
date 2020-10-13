using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StaffList.Database;
using StaffList.API.Employees;

namespace StaffList.UI.Controllers
{
    [Route("[controller]")]
    public class EmployeesController : Controller
    {
        private readonly AppMSSQLDbContext Context;
        public EmployeesController(AppMSSQLDbContext context)
        {
            Context = context;
        }


        [HttpGet("employees")]
        public IActionResult GetEmployees() => Ok(new GetEmployees(Context).Do());

        [HttpPost("employee")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateEmployee.Request request) => Ok(await new CreateEmployee(Context).Do(request));
    }
}
