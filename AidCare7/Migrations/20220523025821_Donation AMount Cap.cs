using Microsoft.EntityFrameworkCore.Migrations;

namespace AidCare7.Migrations
{
    public partial class DonationAMountCap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OUT_P_NO",
                table: "donation",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OUT_P_NO",
                table: "donation");
        }
    }
}
