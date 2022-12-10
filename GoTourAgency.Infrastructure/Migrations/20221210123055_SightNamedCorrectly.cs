using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoTourAgency.Infrastructure.Migrations
{
    public partial class SightNamedCorrectly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Sites_SiteId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_ToursSites_Sites_SiteId",
                table: "ToursSites");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersSites_Sites_SiteId",
                table: "UsersSites");

            migrationBuilder.DropTable(
                name: "Sites");

            migrationBuilder.RenameColumn(
                name: "SiteId",
                table: "UsersSites",
                newName: "SightId");

            migrationBuilder.RenameIndex(
                name: "IX_UsersSites_SiteId",
                table: "UsersSites",
                newName: "IX_UsersSites_SightId");

            migrationBuilder.RenameColumn(
                name: "SiteId",
                table: "ToursSites",
                newName: "SightId");

            migrationBuilder.RenameIndex(
                name: "IX_ToursSites_SiteId",
                table: "ToursSites",
                newName: "IX_ToursSites_SightId");

            migrationBuilder.RenameColumn(
                name: "SiteId",
                table: "Photos",
                newName: "SightId");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_SiteId",
                table: "Photos",
                newName: "IX_Photos_SightId");

            migrationBuilder.CreateTable(
                name: "Sights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sights_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sights_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sights_CategoryId",
                table: "Sights",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sights_RegionId",
                table: "Sights",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Sights_SightId",
                table: "Photos",
                column: "SightId",
                principalTable: "Sights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToursSites_Sights_SightId",
                table: "ToursSites",
                column: "SightId",
                principalTable: "Sights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersSites_Sights_SightId",
                table: "UsersSites",
                column: "SightId",
                principalTable: "Sights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Sights_SightId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_ToursSites_Sights_SightId",
                table: "ToursSites");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersSites_Sights_SightId",
                table: "UsersSites");

            migrationBuilder.DropTable(
                name: "Sights");

            migrationBuilder.RenameColumn(
                name: "SightId",
                table: "UsersSites",
                newName: "SiteId");

            migrationBuilder.RenameIndex(
                name: "IX_UsersSites_SightId",
                table: "UsersSites",
                newName: "IX_UsersSites_SiteId");

            migrationBuilder.RenameColumn(
                name: "SightId",
                table: "ToursSites",
                newName: "SiteId");

            migrationBuilder.RenameIndex(
                name: "IX_ToursSites_SightId",
                table: "ToursSites",
                newName: "IX_ToursSites_SiteId");

            migrationBuilder.RenameColumn(
                name: "SightId",
                table: "Photos",
                newName: "SiteId");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_SightId",
                table: "Photos",
                newName: "IX_Photos_SiteId");

            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sites_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sites_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sites_CategoryId",
                table: "Sites",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sites_RegionId",
                table: "Sites",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Sites_SiteId",
                table: "Photos",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToursSites_Sites_SiteId",
                table: "ToursSites",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersSites_Sites_SiteId",
                table: "UsersSites",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
