using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCore101.Intro.Migrations
{
    public partial class CreateDepartmentsPeopleRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "People",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_DepartmentId",
                table: "People",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Departments_DepartmentId",
                table: "People",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Departments_DepartmentId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_DepartmentId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "People");
        }
    }
}
