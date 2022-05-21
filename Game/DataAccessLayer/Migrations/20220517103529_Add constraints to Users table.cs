using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class AddconstraintstoUserstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddCheckConstraint(
                name: "CK_Users_Age",
                table: "Users",
                sql: "Age > 13");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Users_Email",
                table: "Users",
                sql: "Email like '%@%'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Users_Age",
                table: "Users");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Users_Email",
                table: "Users");
        }
    }
}
