using Microsoft.EntityFrameworkCore.Migrations;

namespace FixIt.Database.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Sexes_SexId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "SexId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Sexes_SexId",
                table: "Employees",
                column: "SexId",
                principalTable: "Sexes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Sexes_SexId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "SexId",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Sexes_SexId",
                table: "Employees",
                column: "SexId",
                principalTable: "Sexes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
