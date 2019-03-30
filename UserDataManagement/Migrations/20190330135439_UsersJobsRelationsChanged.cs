using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace userDataManagement.Migrations
{
    public partial class UsersJobsRelationsChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersJobs");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Jobs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_ClientId",
                table: "Jobs",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_UserId",
                table: "Jobs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Clients_ClientId",
                table: "Jobs",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Users_UserId",
                table: "Jobs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Clients_ClientId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Users_UserId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_ClientId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_UserId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Jobs");

            migrationBuilder.CreateTable(
                name: "UsersJobs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersJobs", x => x.Id);
                });
        }
    }
}
