using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTaskV4.Migrations
{
    /// <inheritdoc />
    public partial class ChangeFormGrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TUBE_STEEL_GRADE_ID_GRADE",
                table: "TUBE");

            migrationBuilder.DropTable(
                name: "STEEL_GRADE");

            migrationBuilder.DropIndex(
                name: "IX_TUBE_ID_GRADE",
                table: "TUBE");

            migrationBuilder.DropColumn(
                name: "ID_GRADE",
                table: "TUBE");

            migrationBuilder.AddColumn<int>(
                name: "GRADE",
                table: "TUBE",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GRADE",
                table: "TUBE");

            migrationBuilder.AddColumn<Guid>(
                name: "ID_GRADE",
                table: "TUBE",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "STEEL_GRADE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    CREATE_AT = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UPDATE_AT = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NAME = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STEEL_GRADE", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TUBE_ID_GRADE",
                table: "TUBE",
                column: "ID_GRADE");

            migrationBuilder.AddForeignKey(
                name: "FK_TUBE_STEEL_GRADE_ID_GRADE",
                table: "TUBE",
                column: "ID_GRADE",
                principalTable: "STEEL_GRADE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
