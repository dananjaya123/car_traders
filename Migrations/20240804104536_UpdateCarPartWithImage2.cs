using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace car_traders.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCarPartWithImage2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image_url",
                table: "car_parts");

            migrationBuilder.DropColumn(
                name: "Image_url",
                table: "car");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image_data",
                table: "car_parts",
                type: "longblob",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "longblob");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image_data",
                table: "car",
                type: "longblob",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image_data",
                table: "car");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image_data",
                table: "car_parts",
                type: "longblob",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "longblob",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image_url",
                table: "car_parts",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Image_url",
                table: "car",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
