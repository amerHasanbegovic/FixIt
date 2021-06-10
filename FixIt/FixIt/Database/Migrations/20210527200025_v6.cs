using Microsoft.EntityFrameworkCore.Migrations;

namespace FixIt.Database.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "Payments",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Payments");
        }
    }
}
