using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoTourAgency.Infrastructure.Migrations
{
    public partial class DataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Sights",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "ed6caf1b-7dd0-45e0-88d1-74ded6c16c44", "guest@mail.com", false, null, null, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEPzzRUlefA+8R8xRTZxtFBap3ya2Bgu+jl1EtHfQg07knhc0mKTeQChru6ao+8z4NA==", null, false, null, false, "guest@mail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "545bd192-d12a-4c8e-b348-24a78620fbb2", "agent@mail.com", false, null, null, false, null, "agent@mail.com", "agent@mail.com", "AQAAAAEAACcQAAAAEA1zg6Rj4rnLvjyOKBudD05un8u0H+zGFYPAMZf4G7fhnKMk4yTehUKzZr+HNRwkeQ==", null, false, null, false, "agent@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "History" },
                    { 2, "Culture" },
                    { 3, "Nature" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "North" },
                    { 2, "Soutwest" },
                    { 3, "Southeast" }
                });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "PhoneNumber", "UserId" },
                values: new object[] { 1, "+359888888888", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "Sights",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "RegionId" },
                values: new object[] { 1, 3, null, "Chudni mostove", 3 });

            migrationBuilder.InsertData(
                table: "Sights",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "RegionId" },
                values: new object[] { 2, 3, null, "Pobiti kamani", 3 });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "ImageUrl", "SightId" },
                values: new object[] { 1, null, "https://bulgariatravel.org/wp-content/uploads/2016/076_003_Chudnite_mostove.jpg_7362.jpg", 1 });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "ImageUrl", "SightId" },
                values: new object[] { 2, null, "http://1.bp.blogspot.com/-qWh0RQrN-Sw/VbVyDm_A5RI/AAAAAAAAEqQ/J2tEfZ266eY/s1600/Mighty%2Bpillars%2Bwith%2Bthe%2BFertility%2Bstone%2Bin%2Bthe%2Bmiddle%252C%2BThe%2BStone%2BForest%252C%2BVarna%252C%2BBulgaria.jpg", 2 });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Description", "ImageUrl", "SightId" },
                values: new object[] { 3, null, "https://www.descopera.ro/wp-content/uploads/2016/09/15716132/1-wikimedia.jpg", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");

            migrationBuilder.DeleteData(
                table: "Sights",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sights",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Sights",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);
        }
    }
}
