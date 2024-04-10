using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCompanyName.AbpZeroTemplate.Migrations
{
    public partial class Added_SchoolId_To_User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SchoolId",
                table: "AbpUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "AbpUsers");
        }
    }
}
