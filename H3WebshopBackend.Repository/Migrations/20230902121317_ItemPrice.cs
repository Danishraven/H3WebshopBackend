using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace H3WebshopBackend.Repository.Migrations
{
    public partial class ItemPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Item",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Item");
        }
    }
}
