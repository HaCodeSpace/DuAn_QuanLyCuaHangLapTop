using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class phongsss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hoaDons_khachHangs_MaKH",
                table: "hoaDons");

            migrationBuilder.AlterColumn<string>(
                name: "MaKH",
                table: "hoaDons",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDons_khachHangs_MaKH",
                table: "hoaDons",
                column: "MaKH",
                principalTable: "khachHangs",
                principalColumn: "MaKH");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hoaDons_khachHangs_MaKH",
                table: "hoaDons");

            migrationBuilder.AlterColumn<string>(
                name: "MaKH",
                table: "hoaDons",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDons_khachHangs_MaKH",
                table: "hoaDons",
                column: "MaKH",
                principalTable: "khachHangs",
                principalColumn: "MaKH",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
