using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Electronic_Vote.Migrations
{
    public partial class updateCandidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDay",
                table: "Candidates",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Candidates",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdentificationNumber",
                table: "Candidates",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "IdentificationNumber",
                table: "Candidates");
        }
    }
}
