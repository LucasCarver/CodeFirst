using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityCodeFirst.Context
{
    public class CompanyDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public CompanyDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department() { Id = 1, Name = "Research & Development", Location = "Midland, MI", Type = "Science", Budget = 1000000000000 },
                new Department() { Id = 2, Name = "Human Resources", Location = "Dhaka, Bangladesh", Type = "Administrative", Budget = 2000000000000 },
                new Department() { Id = 3, Name = "Fun Department", Location = "Party City, USA", Type = "Administrative", Budget = 53 }
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 1, FirstName = "Peter", LastName = "Venkman", Email = "venkman@ghostbusters.co", DepartmentId = 1 },
                new Employee() { Id = 2, FirstName = "Raymond", LastName = "Stantz", Email = "stantz@ghostbusters.co", DepartmentId = 2},
                new Employee() { Id = 3, FirstName = "Egon", LastName = "Spengler", Email="spengler@ghostbusters.co", DepartmentId = 2},
                new Employee() { Id = 4, FirstName = "Slimer", Email = "slimer@ghosts.co", DepartmentId = 2 },
                new Employee() { Id = 5, FirstName = "Dana", LastName="Barrett", Email="barrett@nyphil.co", DepartmentId = 3}
                );
        }
    }
}