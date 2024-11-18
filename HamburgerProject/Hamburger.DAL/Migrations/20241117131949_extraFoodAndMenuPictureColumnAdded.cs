using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger.DAL.Migrations
{
    /// <inheritdoc />
    public partial class extraFoodAndMenuPictureColumnAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "Menus",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "ExtraFoods",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "ExtraFoods");
        }
    }
}
