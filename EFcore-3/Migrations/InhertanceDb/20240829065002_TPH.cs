using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcore_3.Migrations.InhertanceDb
{
    /// <inheritdoc />
    public partial class TPH : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FullTimeEmployees");

            migrationBuilder.DropTable(
                name: "PartTimeEmployees");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Emplyees",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Emplyees",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "HourRate",
                table: "Emplyees",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfHours",
                table: "Emplyees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Salary",
                table: "Emplyees",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "HourRate",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "NumberOfHours",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Emplyees");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Emplyees",
                newName: "name");

            migrationBuilder.CreateTable(
                name: "FullTimeEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullTimeEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FullTimeEmployees_Emplyees_Id",
                        column: x => x.Id,
                        principalTable: "Emplyees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartTimeEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    HourRate = table.Column<double>(type: "float", nullable: false),
                    NumberOfHours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartTimeEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartTimeEmployees_Emplyees_Id",
                        column: x => x.Id,
                        principalTable: "Emplyees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }
    }
}
