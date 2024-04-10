using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCompanyName.AbpZeroTemplate.Migrations
{
    public partial class Added_Student_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PBStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Major = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Batch = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Group = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ActivityClass = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PBStudents", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PBStudents_StudentId",
                table: "PBStudents",
                column: "StudentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PBStudents");
        }
    }
}
