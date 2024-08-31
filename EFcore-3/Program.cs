using EFcore_3.Context;
using EFcore_3.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

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
            using EmployeeDepartmentDbContext context = new EmployeeDepartmentDbContext();
            //var employee = context.Employees.FirstOrDefault(E => E.Id == 2);
            //Console.WriteLine(employee?.Name ?? "Non");
            //Console.WriteLine(employee.WorkFor?.Name ?? "Non");


            //var dept = context.Departments.FirstOrDefault(E => E.Id == 2);

            //foreach (var d in dept.employees)
            //{
            //    Console.WriteLine(d.Name);
            //}
            #endregion


            #region Join Operations
            //using EmployeeDepartmentDbContext context = new EmployeeDepartmentDbContext();
            //var Result = context.Employees.Join(context.Departments, E => E.WorkFor.Id, D => D.Id,
            //    (E, D) =>
            //    new
            //    {
            //        EmpId = E.Id,
            //        EmpName = E.Name,
            //        DeptId = D.Id,
            //        DeptName = D.Name
            //    });
            //var Result = from employee in context.Employees
            //             join department in context.Departments
            //             on employee.WorkFor.Id equals department.Id
            //             select new
            //             {
            //                 EmpId = employee.Id,
            //                 EmpName = employee.Name,
            //                 DeptId = department.Id,
            //                 DeptName = department.Name
            //             };

            //foreach (var item in Result) 
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Mapping View
            //first add empty migration
            //adding sql script to add view in up method and adding sql script to drop this view 
            //add entity with propties for its columns and in context add dbset for it dont forget add keyless in its entity
            //in onModelCreating add configring to ad it as a view 


            //foreach (var item in context.EmployeeDepartmentView) 
            //{
            //    Console.WriteLine($"{item.EmployeeName}::{item.DepartmentName}");
            //}
            #endregion

            #region Tracking and No Tracking
            //var employee01 = context.Employees.FirstOrDefault(E => E.Id == 1);
            //Console.WriteLine(context.Entry(employee01).State);

            //var employee02 = context.Employees.AsNoTracking().FirstOrDefault(E => E.Id == 2);
            //Console.WriteLine(context.Entry(employee02).State);

            //context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;


            #endregion

            #region Remote vs Local
            #endregion

        }
    }
}
