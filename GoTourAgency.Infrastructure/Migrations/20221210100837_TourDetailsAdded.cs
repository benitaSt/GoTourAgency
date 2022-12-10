using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoTourAgency.Infrastructure.Migrations
{
    public partial class TourDetailsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photoes_Sites_SiteId",
                table: "Photoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photoes",
                table: "Photoes");

            migrationBuilder.DropColumn(
                name: "Review",
                table: "UsersSites");

            migrationBuilder.RenameTable(
                name: "Photoes",
                newName: "Photos");

            migrationBuilder.RenameIndex(
                name: "IX_Photoes_SiteId",
                table: "Photos",
                newName: "IX_Photos_SiteId");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDateAndTime",
                table: "Tours",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MeetingLocation",
                table: "Tours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Tours",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDateAndTime",
                table: "Tours",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Photos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photos",
                table: "Photos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Sites_SiteId",
                table: "Photos",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Sites_SiteId",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photos",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "EndDateAndTime",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "MeetingLocation",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "StartDateAndTime",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Photos");

            migrationBuilder.RenameTable(
                name: "Photos",
                newName: "Photoes");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_SiteId",
                table: "Photoes",
                newName: "IX_Photoes_SiteId");

            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "UsersSites",
                type: "nvarchar(420)",
                maxLength: 420,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photoes",
                table: "Photoes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photoes_Sites_SiteId",
                table: "Photoes",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
