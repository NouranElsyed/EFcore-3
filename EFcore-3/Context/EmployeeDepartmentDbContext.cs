using EFcore_3.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore_3.Context
{
    internal class EmployeeDepartmentDbContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
     
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(" Server = . ; Database = EmployeesWithDepartment ; Integrated Security = True ; TrustServerCertificate = true ");

        }

        public DbSet<EmployeeWithDept> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
