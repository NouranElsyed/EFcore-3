using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcore_3.Migrations.InhertanceDb
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Emplyees",
                table: "Emplyees");

            migrationBuilder.RenameTable(
                name: "Emplyees",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Emplyees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emplyees",
                table: "Emplyees",
                column: "Id");
        }
    }
}
