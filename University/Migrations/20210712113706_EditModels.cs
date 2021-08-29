using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace University.Migrations
{
    public partial class EditModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Attendance");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Student",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstMidName",
                table: "Student",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Group",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Abbreviation",
                table: "Group",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date_Creaction",
                table: "Group",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "FacultyID",
                table: "Group",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date_Attendance",
                table: "Attendance",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

          //  migrationBuilder.AddColumn<int>(
            //    name: "SubjectID",
             //   table: "Attendance",
              //  nullable: false,
         //       defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Abbreviation = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Subject = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                });
            migrationBuilder.AddColumn<int>(
               name: "SubjectID",
              table: "Attendance",
               nullable: false,
                 defaultValue: 0);
           migrationBuilder.CreateIndex(
                name: "IX_Group_FacultyID",
                table: "Group",
                column: "FacultyID");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_SubjectID",
                table: "Attendance",
                column: "SubjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Subject_SubjectID",
                table: "Attendance",
                column: "SubjectID",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Faculty_FacultyID",
                table: "Group",
                column: "FacultyID",
                principalTable: "Faculty",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Subject_SubjectID",
                table: "Attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_Group_Faculty_FacultyID",
                table: "Group");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Group_FacultyID",
                table: "Group");

            migrationBuilder.DropIndex(
                name: "IX_Attendance_SubjectID",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "Abbreviation",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "Date_Creaction",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "FacultyID",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "Date_Attendance",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "SubjectID",
                table: "Attendance");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstMidName",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Group",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Group",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Attendance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Attendance",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
