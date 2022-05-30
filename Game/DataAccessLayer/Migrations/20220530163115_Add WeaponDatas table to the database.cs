using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class AddWeaponDatastabletothedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ThirdProtectionArea",
                table: "ArmorDatas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SecondProtectionArea",
                table: "ArmorDatas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "WeaponDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeaponCommonDataId = table.Column<int>(type: "int", nullable: false),
                    AssemblyDamage = table.Column<double>(type: "float", nullable: false),
                    CritRate = table.Column<double>(type: "float", nullable: false),
                    CritMult = table.Column<double>(type: "float", nullable: false),
                    WeaponType = table.Column<int>(type: "int", nullable: false),
                    WeaponRarity = table.Column<int>(type: "int", nullable: false),
                    PhysicalDamageType = table.Column<int>(type: "int", nullable: false),
                    MagicalDamageType = table.Column<int>(type: "int", nullable: false),
                    MainDamageType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeaponDatas_Items_WeaponCommonDataId",
                        column: x => x.WeaponCommonDataId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeaponDatas_WeaponCommonDataId",
                table: "WeaponDatas",
                column: "WeaponCommonDataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeaponDatas");

            migrationBuilder.AlterColumn<int>(
                name: "ThirdProtectionArea",
                table: "ArmorDatas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SecondProtectionArea",
                table: "ArmorDatas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
