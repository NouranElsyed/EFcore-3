using EFcore_3.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore_3.Context
{
    internal class StudentCourseDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=StudentCourseDB;Integrated Security=True;TrustServerCertificate=true");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }



    }
}
