using EFcore_3.Context;
using EFcore_3.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFcore_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Many to Many relationship

            #endregion

            #region TPC
            // using InhertanceDbContext inhertanceDbContext = new InhertanceDbContext();
            //FullTimeEmployee emp01 = new FullTimeEmployee()
            //{
            //    Name = "Noura",
            //    Email = "Noura@Gmail.com",
            //    address = "Alexandria",
            //    Salary = 20000


            //};
            //PartTimeEmployee emp02 = new PartTimeEmployee()
            //{
            //    Name = "Yomna",
            //    Email = "Yomna@Gmail.com",
            //    address = "Alexandria",
            //    HourRate = 500,
            //    NumberOfHours = 4


            //};
            //inhertanceDbContext.FullTimeEmployees.Add(emp01);
            //inhertanceDbContext.PartTimeEmployees.Add(emp02);

            //inhertanceDbContext.SaveChanges();
            #endregion
            #region TPH
            //using InhertanceDbContext inhertanceDbContext = new InhertanceDbContext();
            //FullTimeEmployee emp01 = new FullTimeEmployee()
            //{
            //    Name = "Noura",
            //    Email = "Noura@Gmail.com",
            //    address = "Alexandria",
            //    Salary = 20000


            //};
            //PartTimeEmployee emp02 = new PartTimeEmployee()
            //{
            //    Name = "Yomna",
            //    Email = "Yomna@Gmail.com",
            //    address = "Alexandria",
            //    HourRate = 500,
            //    NumberOfHours = 4


            //};
            //inhertanceDbContext.Employees.Add(emp01);
            //inhertanceDbContext.Employees.Add(emp02);

            //inhertanceDbContext.SaveChanges();
            //var Result = inhertanceDbContext.Employees.OfType<FullTimeEmployee>();
            //foreach (var result in Result) { Console.WriteLine(result.Name); }
            #endregion
            #region TPCC
            //using InhertanceDbContext inhertanceDbContext = new InhertanceDbContext();
            //FullTimeEmployee emp01 = new FullTimeEmployee()
            //{
            //    Name = "Noura",
            //    Email = "Noura@Gmail.com",
            //    address = "Alexandria",
            //    Salary = 20000


            //};
            //PartTimeEmployee emp02 = new PartTimeEmployee()
            //{
            //    Name = "Yomna",
            //    Email = "Yomna@Gmail.com",
            //    address = "Alexandria",
            //    HourRate = 500,
            //    NumberOfHours = 4


            //};
            //inhertanceDbContext.FullTimeEmployees.Add(emp01);
            //inhertanceDbContext.PartTimeEmployees.Add(emp02);

            //inhertanceDbContext.SaveChanges();




            #endregion

            #region Explicit Loading
            //using EmployeeDepartmentDbContext context= new EmployeeDepartmentDbContext();
            //var employee = context.Employees.FirstOrDefault(E=>E.Id==2);
            //context.Entry(employee).Reference("WorkFor").Load();
            //Console.WriteLine(employee?.Name?? "Non");
            //Console.WriteLine(employee.WorkFor?.Name??"Non");


            //var dept = context.Departments.FirstOrDefault(E => E.Id == 2);
            //context.Entry(dept).Collection("employees").Load();
            //foreach (var d in dept.employees) 
            //{
            //    Console.WriteLine(d.Name);
            //}
            #endregion
            #region Eager Loading
            //using EmployeeDepartmentDbContext context = new EmployeeDepartmentDbContext();
            //var employee = context.Employees.Include("WorkFor").FirstOrDefault(E => E.Id == 2);
            //Console.WriteLine(employee?.Name ?? "Non");
            //Console.WriteLine(employee.WorkFor?.Name ?? "Non");


            //var dept = context.Departments.Include(D=>D.employees).FirstOrDefault(E => E.Id == 2);

            //foreach (var d in dept.employees)
            //{
            //    Console.WriteLine(d.Name);
            //}
            #endregion
            #region Lazy Loading 
            //using EmployeeDepartmentDbContext context = new EmployeeDepartmentDbContext();
            //var employee = context.Employees.FirstOrDefault(E => E.Id == 2);
            //Console.WriteLine(employee?.Name ?? "Non");
            //Console.WriteLine(employee.WorkFor?.Name ?? "Non");


            //var dept = context.Departments.FirstOrDefault(E => E.Id == 2);

            //foreach (var d in dept.employees)
            //{
            //    Console.WriteLine(d.Name);
            //}
            #endregion


        }
    }
}
