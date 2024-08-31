using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcore_3.Migrations.EmployeeDepartmentDb
{
    /// <inheritdoc />
    public partial class EmployeeDepartmentView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create view EmployeeDepartmentView 
                                    with encryption
                                    as
                                    select E.Id EmployeeId , E.Name EmployeeName ,  D.Name DepartmentName , D.Id DepartmentId
                                    from Departments D , Employees E
                                    where D.Id = E.DeptID ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"drop view EmployeeDepartmentView ");
        }
    }
}
