using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoTourAgency.Infrastructure.Migrations
{
    public partial class TourPriceValidationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Tours",
                type: "money",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Tours",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldPrecision: 18,
                oldScale: 2);
        }
    }
}
