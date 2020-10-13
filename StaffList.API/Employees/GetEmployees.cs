using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StaffList.Database;

namespace StaffList.API.Employees
{
    public class GetEmployees
    {
        private readonly AppMSSQLDbContext Context;
        public GetEmployees(AppMSSQLDbContext context)
        {
            Context = context;
        }

        public IEnumerable<EmployeeViewModel> Do()
        {

            IEnumerable<EmployeeViewModel> allEmployees = Context.Employees.ToList().Select(e => new EmployeeViewModel
            {
                FullName = e.FullName,
                Position = e.Position,
                Birthday = e.Birthday.ToShortDateString(),
                Description = e.Description,
                MaternityLeave = e.MaternityLeave

            });
            return allEmployees;
        }

        public class EmployeeViewModel 
        {
            public string FullName { get; set; }
            public string Position { get; set; }
            public string Birthday { get; set; }
            public string Description { get; set; }
            public bool MaternityLeave { get; set; }
        }
    }
}
