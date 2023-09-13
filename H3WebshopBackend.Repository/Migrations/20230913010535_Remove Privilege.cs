using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace H3WebshopBackend.Repository.Migrations
{
    public partial class RemovePrivilege : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Privileged",
                table: "Customer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Privileged",
                table: "Customer",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
