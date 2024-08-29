using EFcore_3.Context;
using EFcore_3.Entities;

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



        }
    }
}
