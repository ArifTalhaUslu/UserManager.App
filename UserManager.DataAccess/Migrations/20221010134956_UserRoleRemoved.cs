using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManager.DataAccess.Migrations
{
    public partial class UserRoleRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "UserInfos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserRole",
                table: "UserInfos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
