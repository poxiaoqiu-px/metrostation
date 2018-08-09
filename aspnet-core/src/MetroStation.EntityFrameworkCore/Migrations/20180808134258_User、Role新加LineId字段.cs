using Microsoft.EntityFrameworkCore.Migrations;

namespace MetroStation.Migrations
{
    public partial class UserRole新加LineId字段 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LineId",
                table: "AbpUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LineId",
                table: "AbpRoles",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LineId",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "LineId",
                table: "AbpRoles");
        }
    }
}
