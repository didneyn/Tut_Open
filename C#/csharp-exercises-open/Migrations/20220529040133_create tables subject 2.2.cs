using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_exercises_open.Migrations
{
    public partial class createtablessubject22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "createBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Studenst");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Studenst");

            migrationBuilder.DropColumn(
                name: "createBy",
                table: "Studenst");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "PrincipalObjectives");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "PrincipalObjectives");

            migrationBuilder.DropColumn(
                name: "createBy",
                table: "PrincipalObjectives");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Objectives");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Objectives");

            migrationBuilder.DropColumn(
                name: "createBy",
                table: "Objectives");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "createBy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "createBy",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "createBy",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CreateById",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateById",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreateById",
                table: "Studenst",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "Studenst",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateById",
                table: "Studenst",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreateById",
                table: "PrincipalObjectives",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "PrincipalObjectives",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateById",
                table: "PrincipalObjectives",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreateById",
                table: "Objectives",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "Objectives",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateById",
                table: "Objectives",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreateById",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateById",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreateById",
                table: "Chapters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "Chapters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateById",
                table: "Chapters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreateById",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateById",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreateById",
                table: "Users",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DeletedById",
                table: "Users",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UpdateById",
                table: "Users",
                column: "UpdateById");

            migrationBuilder.CreateIndex(
                name: "IX_Studenst_CreateById",
                table: "Studenst",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_Studenst_DeletedById",
                table: "Studenst",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Studenst_UpdateById",
                table: "Studenst",
                column: "UpdateById");

            migrationBuilder.CreateIndex(
                name: "IX_PrincipalObjectives_CreateById",
                table: "PrincipalObjectives",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_PrincipalObjectives_DeletedById",
                table: "PrincipalObjectives",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_PrincipalObjectives_UpdateById",
                table: "PrincipalObjectives",
                column: "UpdateById");

            migrationBuilder.CreateIndex(
                name: "IX_Objectives_CreateById",
                table: "Objectives",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_Objectives_DeletedById",
                table: "Objectives",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Objectives_UpdateById",
                table: "Objectives",
                column: "UpdateById");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CreateById",
                table: "Courses",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DeletedById",
                table: "Courses",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_UpdateById",
                table: "Courses",
                column: "UpdateById");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_CreateById",
                table: "Chapters",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_DeletedById",
                table: "Chapters",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_UpdateById",
                table: "Chapters",
                column: "UpdateById");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CreateById",
                table: "Categories",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_DeletedById",
                table: "Categories",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_UpdateById",
                table: "Categories",
                column: "UpdateById");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_CreateById",
                table: "Categories",
                column: "CreateById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_DeletedById",
                table: "Categories",
                column: "DeletedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_UpdateById",
                table: "Categories",
                column: "UpdateById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Users_CreateById",
                table: "Chapters",
                column: "CreateById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Users_DeletedById",
                table: "Chapters",
                column: "DeletedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Users_UpdateById",
                table: "Chapters",
                column: "UpdateById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_CreateById",
                table: "Courses",
                column: "CreateById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_DeletedById",
                table: "Courses",
                column: "DeletedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_UpdateById",
                table: "Courses",
                column: "UpdateById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Objectives_Users_CreateById",
                table: "Objectives",
                column: "CreateById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Objectives_Users_DeletedById",
                table: "Objectives",
                column: "DeletedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Objectives_Users_UpdateById",
                table: "Objectives",
                column: "UpdateById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrincipalObjectives_Users_CreateById",
                table: "PrincipalObjectives",
                column: "CreateById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrincipalObjectives_Users_DeletedById",
                table: "PrincipalObjectives",
                column: "DeletedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrincipalObjectives_Users_UpdateById",
                table: "PrincipalObjectives",
                column: "UpdateById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Studenst_Users_CreateById",
                table: "Studenst",
                column: "CreateById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Studenst_Users_DeletedById",
                table: "Studenst",
                column: "DeletedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Studenst_Users_UpdateById",
                table: "Studenst",
                column: "UpdateById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_CreateById",
                table: "Users",
                column: "CreateById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_DeletedById",
                table: "Users",
                column: "DeletedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_UpdateById",
                table: "Users",
                column: "UpdateById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_CreateById",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_DeletedById",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_UpdateById",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Users_CreateById",
                table: "Chapters");

            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Users_DeletedById",
                table: "Chapters");

            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Users_UpdateById",
                table: "Chapters");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_CreateById",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_DeletedById",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_UpdateById",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Objectives_Users_CreateById",
                table: "Objectives");

            migrationBuilder.DropForeignKey(
                name: "FK_Objectives_Users_DeletedById",
                table: "Objectives");

            migrationBuilder.DropForeignKey(
                name: "FK_Objectives_Users_UpdateById",
                table: "Objectives");

            migrationBuilder.DropForeignKey(
                name: "FK_PrincipalObjectives_Users_CreateById",
                table: "PrincipalObjectives");

            migrationBuilder.DropForeignKey(
                name: "FK_PrincipalObjectives_Users_DeletedById",
                table: "PrincipalObjectives");

            migrationBuilder.DropForeignKey(
                name: "FK_PrincipalObjectives_Users_UpdateById",
                table: "PrincipalObjectives");

            migrationBuilder.DropForeignKey(
                name: "FK_Studenst_Users_CreateById",
                table: "Studenst");

            migrationBuilder.DropForeignKey(
                name: "FK_Studenst_Users_DeletedById",
                table: "Studenst");

            migrationBuilder.DropForeignKey(
                name: "FK_Studenst_Users_UpdateById",
                table: "Studenst");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_CreateById",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_DeletedById",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_UpdateById",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CreateById",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_DeletedById",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UpdateById",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Studenst_CreateById",
                table: "Studenst");

            migrationBuilder.DropIndex(
                name: "IX_Studenst_DeletedById",
                table: "Studenst");

            migrationBuilder.DropIndex(
                name: "IX_Studenst_UpdateById",
                table: "Studenst");

            migrationBuilder.DropIndex(
                name: "IX_PrincipalObjectives_CreateById",
                table: "PrincipalObjectives");

            migrationBuilder.DropIndex(
                name: "IX_PrincipalObjectives_DeletedById",
                table: "PrincipalObjectives");

            migrationBuilder.DropIndex(
                name: "IX_PrincipalObjectives_UpdateById",
                table: "PrincipalObjectives");

            migrationBuilder.DropIndex(
                name: "IX_Objectives_CreateById",
                table: "Objectives");

            migrationBuilder.DropIndex(
                name: "IX_Objectives_DeletedById",
                table: "Objectives");

            migrationBuilder.DropIndex(
                name: "IX_Objectives_UpdateById",
                table: "Objectives");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CreateById",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_DeletedById",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_UpdateById",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Chapters_CreateById",
                table: "Chapters");

            migrationBuilder.DropIndex(
                name: "IX_Chapters_DeletedById",
                table: "Chapters");

            migrationBuilder.DropIndex(
                name: "IX_Chapters_UpdateById",
                table: "Chapters");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CreateById",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_DeletedById",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_UpdateById",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreateById",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdateById",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreateById",
                table: "Studenst");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Studenst");

            migrationBuilder.DropColumn(
                name: "UpdateById",
                table: "Studenst");

            migrationBuilder.DropColumn(
                name: "CreateById",
                table: "PrincipalObjectives");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "PrincipalObjectives");

            migrationBuilder.DropColumn(
                name: "UpdateById",
                table: "PrincipalObjectives");

            migrationBuilder.DropColumn(
                name: "CreateById",
                table: "Objectives");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Objectives");

            migrationBuilder.DropColumn(
                name: "UpdateById",
                table: "Objectives");

            migrationBuilder.DropColumn(
                name: "CreateById",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UpdateById",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CreateById",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "UpdateById",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "CreateById",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UpdateById",
                table: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "createBy",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Studenst",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Studenst",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "createBy",
                table: "Studenst",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "PrincipalObjectives",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "PrincipalObjectives",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "createBy",
                table: "PrincipalObjectives",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Objectives",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Objectives",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "createBy",
                table: "Objectives",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "createBy",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Chapters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Chapters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "createBy",
                table: "Chapters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "createBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
