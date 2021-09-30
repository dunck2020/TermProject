using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject_S1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 30, nullable: true),
                    State = table.Column<string>(maxLength: 2, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Discount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Address", "City", "Discount", "EmailAddress", "Name", "PhoneNumber", "State", "ZipCode" },
                values: new object[] { 1, "1550 Main St", "Traverse City", 0.10000000000000001, "jacksfishmarket@hotmail.com", "Jack's Fish Market", "231-555-9999", "MI", "49684" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Address", "City", "Discount", "EmailAddress", "Name", "PhoneNumber", "State", "ZipCode" },
                values: new object[] { 2, "230 Business Park Dr", "Traverse City", 0.0, null, "ProSource Cabinets", "231-555-5555", "MI", "49686" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Address", "City", "Discount", "EmailAddress", "Name", "PhoneNumber", "State", "ZipCode" },
                values: new object[] { 3, "231 8th St", "Traverse City", 0.0, null, "Up North Flower Shop", null, "MI", "49684" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
