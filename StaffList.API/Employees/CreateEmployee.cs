using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StaffList.Database;
using StaffList.Domain.Models;

namespace StaffList.API.Employees
{
    public class CreateEmployee
    {

        private readonly AppMSSQLDbContext Context;
        public CreateEmployee(AppMSSQLDbContext context)
        {
            Context = context;
        }

        public async Task<Response> Do(Request request)
        {
            var employee = new Employee
            {
                FullName = request.FullName,
                Position = request.Position,
                Birthday = request.Birthday,
                Description = request.Description,
                MaternityLeave = request.MaternityLeave
            };

            Context.Employees.Add(employee);

            await Context.SaveChangesAsync();

            return new Response
            {
                FullName = employee.FullName,
                Position = employee.Position,
                Birthday = employee.Birthday.ToShortDateString(),
                Description = employee.Description,
                MaternityLeave = employee.MaternityLeave
            };
            
        }

        public class Request
        {
            public string FullName { get; set; }
            public string Position { get; set; }
            public DateTime Birthday { get; set; }
            public string Description { get; set; }
            public bool MaternityLeave { get; set; }
        }

        public class Response
        {
            public string FullName { get; set; }
            public string Position { get; set; }
            public string Birthday { get; set; }
            public string Description { get; set; }
            public bool MaternityLeave { get; set; }
        }
    }
}
