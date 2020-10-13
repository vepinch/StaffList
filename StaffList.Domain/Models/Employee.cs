using System;
using System.Collections.Generic;
using System.Text;

namespace StaffList.Domain.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public DateTime Birthday { get; set; }
        public string Description { get; set; }
        public bool MaternityLeave { get; set; }
    }
}
