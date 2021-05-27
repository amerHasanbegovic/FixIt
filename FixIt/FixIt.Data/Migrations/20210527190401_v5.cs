using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FixIt.Data.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_JobDetails_JobDetailsId",
                table: "Jobs");

            migrationBuilder.DropTable(
                name: "JobDetails");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_JobDetailsId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "JobDetailsId",
                table: "Jobs");

            migrationBuilder.AddColumn<string>(
                name: "JobDescription",
                table: "ServiceRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobDescription",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Paid",
                table: "Jobs",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobDescription",
                table: "ServiceRequests");

            migrationBuilder.DropColumn(
                name: "JobDescription",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "Paid",
                table: "Jobs");

            migrationBuilder.AddColumn<int>(
                name: "JobDetailsId",
                table: "Jobs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "JobDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Paid = table.Column<bool>(type: "bit", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDetails", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_JobDetailsId",
                table: "Jobs",
                column: "JobDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_JobDetails_JobDetailsId",
                table: "Jobs",
                column: "JobDetailsId",
                principalTable: "JobDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
