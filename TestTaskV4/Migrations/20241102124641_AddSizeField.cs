using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTaskV4.Migrations
{
    /// <inheritdoc />
    public partial class AddSizeField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "SIZE",
                table: "TUBE",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SIZE",
                table: "TUBE");
        }
    }
}
