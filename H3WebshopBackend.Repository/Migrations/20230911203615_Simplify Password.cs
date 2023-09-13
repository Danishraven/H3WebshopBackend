using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace H3WebshopBackend.Repository.Migrations
{
    public partial class SimplifyPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordIterations",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "PasswordKeySize",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Customer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PasswordIterations",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PasswordKeySize",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Customer",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
