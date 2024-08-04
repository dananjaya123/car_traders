using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace car_traders.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCarPartWithImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image_data",
                table: "car_parts",
                type: "longblob",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image_data",
                table: "car_parts");
        }
    }
}
