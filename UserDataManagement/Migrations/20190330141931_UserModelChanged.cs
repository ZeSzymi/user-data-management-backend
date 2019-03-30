using Microsoft.EntityFrameworkCore.Migrations;

namespace userDataManagement.Migrations
{
    public partial class UserModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeOfWork",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "HoursWorked",
                table: "Users",
                newName: "Phone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Users",
                newName: "HoursWorked");

            migrationBuilder.AddColumn<string>(
                name: "TypeOfWork",
                table: "Users",
                nullable: true);
        }
    }
}
