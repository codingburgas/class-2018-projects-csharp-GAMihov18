using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Testnewidea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_OffHandId",
                table: "CharacterDatas");

            migrationBuilder.DropIndex(
                name: "IX_CharacterDatas_OffHandId",
                table: "CharacterDatas");

            migrationBuilder.DropColumn(
                name: "OffHandId",
                table: "CharacterDatas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OffHandId",
                table: "CharacterDatas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDatas_OffHandId",
                table: "CharacterDatas",
                column: "OffHandId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_OffHandId",
                table: "CharacterDatas",
                column: "OffHandId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
