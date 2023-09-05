using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace stoktakipwebapp.Migrations
{
    /// <inheritdoc />
    public partial class ılkı : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dealaer",
                table: "Products",
                newName: "Dealer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dealer",
                table: "Products",
                newName: "Dealaer");
        }
    }
}
