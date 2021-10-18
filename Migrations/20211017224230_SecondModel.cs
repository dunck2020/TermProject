using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject_S1.Migrations
{
    public partial class SecondModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerGradeID",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CustomerGrades",
                columns: table => new
                {
                    CustomerGradeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerSalesLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerGrades", x => x.CustomerGradeID);
                });

            migrationBuilder.InsertData(
                table: "CustomerGrades",
                columns: new[] { "CustomerGradeID", "CustomerSalesLevel" },
                values: new object[,]
                {
                    { 1, "A" },
                    { 2, "B" },
                    { 3, "C" },
                    { 4, "D" },
                    { 5, "E" }
                });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "CustomerGradeID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "CustomerGradeID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                column: "CustomerGradeID",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CustomerGradeID",
                table: "Customer",
                column: "CustomerGradeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_CustomerGrades_CustomerGradeID",
                table: "Customer",
                column: "CustomerGradeID",
                principalTable: "CustomerGrades",
                principalColumn: "CustomerGradeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_CustomerGrades_CustomerGradeID",
                table: "Customer");

            migrationBuilder.DropTable(
                name: "CustomerGrades");

            migrationBuilder.DropIndex(
                name: "IX_Customer_CustomerGradeID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CustomerGradeID",
                table: "Customer");
        }
    }
}
