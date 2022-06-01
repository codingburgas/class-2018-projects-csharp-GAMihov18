using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Returnoffhandfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_ArmsId",
                table: "CharacterDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_ChestId",
                table: "CharacterDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_FeetId",
                table: "CharacterDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_HandsId",
                table: "CharacterDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_HeadId",
                table: "CharacterDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_LegsId",
                table: "CharacterDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_MainHandId",
                table: "CharacterDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_ShouldersId",
                table: "CharacterDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_WaistId",
                table: "CharacterDatas");

            migrationBuilder.AlterColumn<int>(
                name: "WaistId",
                table: "CharacterDatas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ShouldersId",
                table: "CharacterDatas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MainHandId",
                table: "CharacterDatas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LegsId",
                table: "CharacterDatas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HeadId",
                table: "CharacterDatas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HandsId",
                table: "CharacterDatas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FeetId",
                table: "CharacterDatas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ChestId",
                table: "CharacterDatas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ArmsId",
                table: "CharacterDatas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "OffHandId",
                table: "CharacterDatas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDatas_OffHandId",
                table: "CharacterDatas",
                column: "OffHandId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_ArmsId",
                table: "CharacterDatas",
                column: "ArmsId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_ChestId",
                table: "CharacterDatas",
                column: "ChestId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_FeetId",
                table: "CharacterDatas",
                column: "FeetId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_HandsId",
                table: "CharacterDatas",
                column: "HandsId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_HeadId",
                table: "CharacterDatas",
                column: "HeadId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_LegsId",
                table: "CharacterDatas",
                column: "LegsId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_MainHandId",
                table: "CharacterDatas",
                column: "MainHandId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_OffHandId",
                table: "CharacterDatas",
                column: "OffHandId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_ShouldersId",
                table: "CharacterDatas",
                column: "ShouldersId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_WaistId",
                table: "CharacterDatas",
                column: "WaistId",
                principalTable: "Items",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_ArmsId",
                table: "CharacterDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_ChestId",
                table: "CharacterDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_FeetId",
                table: "CharacterDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_HandsId",
                table: "CharacterDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_HeadId",
                table: "CharacterDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_LegsId",
                table: "CharacterDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_MainHandId",
                table: "CharacterDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_OffHandId",
                table: "CharacterDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_ShouldersId",
                table: "CharacterDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDatas_Items_WaistId",
                table: "CharacterDatas");

            migrationBuilder.DropIndex(
                name: "IX_CharacterDatas_OffHandId",
                table: "CharacterDatas");

            migrationBuilder.DropColumn(
                name: "OffHandId",
                table: "CharacterDatas");

            migrationBuilder.AlterColumn<int>(
                name: "WaistId",
                table: "CharacterDatas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShouldersId",
                table: "CharacterDatas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MainHandId",
                table: "CharacterDatas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LegsId",
                table: "CharacterDatas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HeadId",
                table: "CharacterDatas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HandsId",
                table: "CharacterDatas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FeetId",
                table: "CharacterDatas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChestId",
                table: "CharacterDatas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArmsId",
                table: "CharacterDatas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_ArmsId",
                table: "CharacterDatas",
                column: "ArmsId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_ChestId",
                table: "CharacterDatas",
                column: "ChestId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_FeetId",
                table: "CharacterDatas",
                column: "FeetId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_HandsId",
                table: "CharacterDatas",
                column: "HandsId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_HeadId",
                table: "CharacterDatas",
                column: "HeadId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_LegsId",
                table: "CharacterDatas",
                column: "LegsId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_MainHandId",
                table: "CharacterDatas",
                column: "MainHandId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_ShouldersId",
                table: "CharacterDatas",
                column: "ShouldersId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDatas_Items_WaistId",
                table: "CharacterDatas",
                column: "WaistId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
