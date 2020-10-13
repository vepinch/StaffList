using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using StaffList.Domain.Models;

namespace StaffList.Database
{
    public class AppMSSQLDbContext : DbContext
    {
        public AppMSSQLDbContext(DbContextOptions<AppMSSQLDbContext> options) : base(options)  
        {
           
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    ID = 1,
                    FullName = "Иванов Иван Иванович",
                    Position = "Инженер",
                    Birthday = DateTime.Parse("1/9/1981"),
                    Description = "description",
                    MaternityLeave = false
                },
                   new Employee
                   {
                       ID = 2,
                       FullName = "Иванова Инна Ивановна",
                       Position = "Инженер",
                       Birthday = DateTime.Parse("2/1/1981"),
                       Description = "description",
                       MaternityLeave = true
                   }, new Employee
                   {
                       ID = 3,
                       FullName = "Петров Петр Петрович",
                       Position = "Инженер",
                       Birthday = DateTime.Parse("3/5/1981"),
                       Description = "description",
                       MaternityLeave = true
                   }, new Employee
                   {
                       ID = 4,
                       FullName = "Петрова Полина Петровна",
                       Position = "Инженер",
                       Birthday = DateTime.Parse("4/12/1981"),
                       Description = "description",
                       MaternityLeave = false
                   }, new Employee
                   {
                       ID = 5,
                       FullName = "Егоров Устин Евсеевич",
                       Position = "Старший инженер",
                       Birthday = DateTime.Parse("8/8/1981"),
                       Description = "description",
                       MaternityLeave = false
                   }, new Employee
                   {
                       ID = 6,
                       FullName = "Морозова Аурелия Георгиевна",
                       Position = "Старший инженер",
                       Birthday = DateTime.Parse("9/7/1981"),
                       Description = "description",
                       MaternityLeave = true
                   }, new Employee
                   {
                       ID = 7,
                       FullName = "Наумов Модест Лаврентьевич",
                       Position = "Старший инженер",
                       Birthday = DateTime.Parse("10/11/1981"),
                       Description = "description",
                       MaternityLeave = true
                   }, new Employee
                   {
                       ID = 8,
                       FullName = "Шестакова Кира Митрофановна",
                       Position = "Старший инженер",
                       Birthday = DateTime.Parse("11/4/1981"),
                       Description = "description",
                       MaternityLeave = true
                   }, new Employee
                   {
                       ID = 9,
                       FullName = "Жуков Альберт Германнович",
                       Position = "Ведущий инженер",
                       Birthday = DateTime.Parse("13/2/1981"),
                       Description = "description",
                       MaternityLeave = false
                   }, new Employee
                   {
                       ID = 10,
                       FullName = "Гусева Наталья Арсеньевна",
                       Position = "Ведущий инженер",
                       Birthday = DateTime.Parse("14/1/1981"),
                       Description = "description",
                       MaternityLeave = true
                   }
                );
        }
    }
}
