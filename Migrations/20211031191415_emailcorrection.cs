using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject_S1.Migrations
{
    public partial class emailcorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_CustomerGrades_CustomerGradeID",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "CustomerGradeID",
                table: "Customer",
                newName: "Customer Sales Level");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_CustomerGradeID",
                table: "Customer",
                newName: "IX_Customer_Customer Sales Level");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_CustomerGrades_Customer Sales Level",
                table: "Customer",
                column: "Customer Sales Level",
                principalTable: "CustomerGrades",
                principalColumn: "CustomerGradeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_CustomerGrades_Customer Sales Level",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "Customer Sales Level",
                table: "Customer",
                newName: "CustomerGradeID");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_Customer Sales Level",
                table: "Customer",
                newName: "IX_Customer_CustomerGradeID");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_CustomerGrades_CustomerGradeID",
                table: "Customer",
                column: "CustomerGradeID",
                principalTable: "CustomerGrades",
                principalColumn: "CustomerGradeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
