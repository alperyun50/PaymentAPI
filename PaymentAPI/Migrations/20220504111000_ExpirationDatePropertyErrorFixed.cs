using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentAPI.Migrations
{
    public partial class ExpirationDatePropertyErrorFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExprationDate",
                table: "PaymentDetails",
                newName: "ExpirationDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpirationDate",
                table: "PaymentDetails",
                newName: "ExprationDate");
        }
    }
}
