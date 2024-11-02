using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTaskV4.Migrations
{
    /// <inheritdoc />
    public partial class ChangeError : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WEIGHT",
                table: "STEEL_GRADE",
                newName: "NAME");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "STEEL_GRADE",
                newName: "WEIGHT");
        }
    }
}
