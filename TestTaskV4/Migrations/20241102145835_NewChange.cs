using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTaskV4.Migrations
{
    /// <inheritdoc />
    public partial class NewChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PACK_TUBE_ID_TUBE",
                table: "PACK");

            migrationBuilder.DropIndex(
                name: "IX_PACK_ID_TUBE",
                table: "PACK");

            migrationBuilder.DropColumn(
                name: "ID_TUBE",
                table: "PACK");

            migrationBuilder.AddColumn<Guid>(
                name: "ID_TUBE",
                table: "TUBE",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TUBE_ID_TUBE",
                table: "TUBE",
                column: "ID_TUBE");

            migrationBuilder.AddForeignKey(
                name: "FK_TUBE_PACK_ID_TUBE",
                table: "TUBE",
                column: "ID_TUBE",
                principalTable: "PACK",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TUBE_PACK_ID_TUBE",
                table: "TUBE");

            migrationBuilder.DropIndex(
                name: "IX_TUBE_ID_TUBE",
                table: "TUBE");

            migrationBuilder.DropColumn(
                name: "ID_TUBE",
                table: "TUBE");

            migrationBuilder.AddColumn<Guid>(
                name: "ID_TUBE",
                table: "PACK",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_PACK_ID_TUBE",
                table: "PACK",
                column: "ID_TUBE");

            migrationBuilder.AddForeignKey(
                name: "FK_PACK_TUBE_ID_TUBE",
                table: "PACK",
                column: "ID_TUBE",
                principalTable: "TUBE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
