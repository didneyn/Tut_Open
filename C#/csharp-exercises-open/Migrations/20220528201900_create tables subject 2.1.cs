using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_exercises_open.Migrations
{
    public partial class createtablessubject21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryCourse_Categories_CategoryId",
                table: "CategoryCourse");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "CategoryCourse",
                newName: "CategoriesId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryCourse_Categories_CategoriesId",
                table: "CategoryCourse",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryCourse_Categories_CategoriesId",
                table: "CategoryCourse");

            migrationBuilder.RenameColumn(
                name: "CategoriesId",
                table: "CategoryCourse",
                newName: "CategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryCourse_Categories_CategoryId",
                table: "CategoryCourse",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
