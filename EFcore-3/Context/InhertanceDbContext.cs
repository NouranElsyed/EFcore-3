using EFcore_3.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore_3.Context
{
    internal class InhertanceDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region  TPC
            //modelBuilder.Entity<Employee>().ToTable("Emplyees");

            //modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");

            //modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");
            #endregion
            #region  TPH
            //modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
            //modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();
            #endregion


            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" Server = . ; Database = InhertEmployee ; Integrated Security = True ; TrustServerCertificate = true ");

        }
        //public DbSet<Employee> Employees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }



    }
}
