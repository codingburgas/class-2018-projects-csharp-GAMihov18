using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class AddArmordata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArmorDatas",
                columns: table => new
                {
                    ArmorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArmorCommonDataId = table.Column<int>(type: "int", nullable: false),
                    AssemblyArmor = table.Column<double>(type: "float", nullable: false),
                    ArmorRarity = table.Column<int>(type: "int", nullable: false),
                    ArmorType = table.Column<int>(type: "int", nullable: false),
                    ArmorEquipSlot = table.Column<int>(type: "int", nullable: false),
                    FirstProtectionArea = table.Column<int>(type: "int", nullable: false),
                    SecondProtectionArea = table.Column<int>(type: "int", nullable: true),
                    ThirdProtectionArea = table.Column<int>(type: "int", nullable: true),
                    SlashingResistance = table.Column<double>(type: "float", nullable: false),
                    PiercingResistance = table.Column<double>(type: "float", nullable: false),
                    BluntResistance = table.Column<double>(type: "float", nullable: false),
                    FireResistance = table.Column<double>(type: "float", nullable: false),
                    WaterResistance = table.Column<double>(type: "float", nullable: false),
                    EarthResistance = table.Column<double>(type: "float", nullable: false),
                    AirResistance = table.Column<double>(type: "float", nullable: false),
                    LuxResistance = table.Column<double>(type: "float", nullable: false),
                    VoidResistance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorDatas", x => x.ArmorId);
                    table.ForeignKey(
                        name: "FK_ArmorDatas_Items_ArmorCommonDataId",
                        column: x => x.ArmorCommonDataId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArmorDatas_ArmorCommonDataId",
                table: "ArmorDatas",
                column: "ArmorCommonDataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArmorDatas");
        }
    }
}
