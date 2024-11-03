using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTaskV4.Migrations
{
    /// <inheritdoc />
    public partial class ChangeBool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TUBE_PACK_ID_TUBE",
                table: "TUBE");

            migrationBuilder.DropColumn(
                name: "IS_PACKED",
                table: "TUBE");

            migrationBuilder.RenameColumn(
                name: "ID_TUBE",
                table: "TUBE",
                newName: "ID_PACK");

            migrationBuilder.RenameIndex(
                name: "IX_TUBE_ID_TUBE",
                table: "TUBE",
                newName: "IX_TUBE_ID_PACK");

            migrationBuilder.AddForeignKey(
                name: "FK_TUBE_PACK_ID_PACK",
                table: "TUBE",
                column: "ID_PACK",
                principalTable: "PACK",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TUBE_PACK_ID_PACK",
                table: "TUBE");

            migrationBuilder.RenameColumn(
                name: "ID_PACK",
                table: "TUBE",
                newName: "ID_TUBE");

            migrationBuilder.RenameIndex(
                name: "IX_TUBE_ID_PACK",
                table: "TUBE",
                newName: "IX_TUBE_ID_TUBE");

            migrationBuilder.AddColumn<bool>(
                name: "IS_PACKED",
                table: "TUBE",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_TUBE_PACK_ID_TUBE",
                table: "TUBE",
                column: "ID_TUBE",
                principalTable: "PACK",
                principalColumn: "ID");
        }
    }
}
