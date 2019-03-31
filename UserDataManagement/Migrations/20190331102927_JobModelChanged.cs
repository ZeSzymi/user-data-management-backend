using Microsoft.EntityFrameworkCore.Migrations;

namespace userDataManagement.Migrations
{
    public partial class JobModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Clients_ClientId",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Jobs",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Jobs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Clients_ClientId",
                table: "Jobs",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Clients_ClientId",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Jobs",
                newName: "Type");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Jobs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Clients_ClientId",
                table: "Jobs",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
