using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Addcharacteddataandcharacterlinktousers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainHandId = table.Column<int>(type: "int", nullable: false),
                    OffHandId = table.Column<int>(type: "int", nullable: false),
                    HeadId = table.Column<int>(type: "int", nullable: false),
                    ShouldersId = table.Column<int>(type: "int", nullable: false),
                    ArmsId = table.Column<int>(type: "int", nullable: false),
                    HandsId = table.Column<int>(type: "int", nullable: false),
                    WaistId = table.Column<int>(type: "int", nullable: false),
                    ChestId = table.Column<int>(type: "int", nullable: false),
                    LegsId = table.Column<int>(type: "int", nullable: false),
                    FeetId = table.Column<int>(type: "int", nullable: false),
                    Health = table.Column<double>(type: "float", nullable: false),
                    Stamina = table.Column<double>(type: "float", nullable: false),
                    StaminaRegenerationRate = table.Column<double>(type: "float", nullable: false),
                    Mana = table.Column<double>(type: "float", nullable: false),
                    ManaRegenerationRate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterDatas_Items_ArmsId",
                        column: x => x.ArmsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CharacterDatas_Items_ChestId",
                        column: x => x.ChestId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CharacterDatas_Items_FeetId",
                        column: x => x.FeetId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CharacterDatas_Items_HandsId",
                        column: x => x.HandsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CharacterDatas_Items_HeadId",
                        column: x => x.HeadId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CharacterDatas_Items_LegsId",
                        column: x => x.LegsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CharacterDatas_Items_MainHandId",
                        column: x => x.MainHandId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CharacterDatas_Items_OffHandId",
                        column: x => x.OffHandId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CharacterDatas_Items_ShouldersId",
                        column: x => x.ShouldersId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CharacterDatas_Items_WaistId",
                        column: x => x.WaistId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UserCharacters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCharacters", x => new { x.UserId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_UserCharacters_CharacterDatas_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "CharacterDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCharacters_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDatas_ArmsId",
                table: "CharacterDatas",
                column: "ArmsId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDatas_ChestId",
                table: "CharacterDatas",
                column: "ChestId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDatas_FeetId",
                table: "CharacterDatas",
                column: "FeetId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDatas_HandsId",
                table: "CharacterDatas",
                column: "HandsId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDatas_HeadId",
                table: "CharacterDatas",
                column: "HeadId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDatas_LegsId",
                table: "CharacterDatas",
                column: "LegsId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDatas_MainHandId",
                table: "CharacterDatas",
                column: "MainHandId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDatas_OffHandId",
                table: "CharacterDatas",
                column: "OffHandId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDatas_ShouldersId",
                table: "CharacterDatas",
                column: "ShouldersId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDatas_WaistId",
                table: "CharacterDatas",
                column: "WaistId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCharacters_CharacterId",
                table: "UserCharacters",
                column: "CharacterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCharacters");

            migrationBuilder.DropTable(
                name: "CharacterDatas");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
