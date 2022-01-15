using Microsoft.EntityFrameworkCore.Migrations;

namespace FiorelloP125.Migrations
{
    public partial class ChangeFlowerImagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "FlowerImages",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "FlowerImages");
        }
    }
}
