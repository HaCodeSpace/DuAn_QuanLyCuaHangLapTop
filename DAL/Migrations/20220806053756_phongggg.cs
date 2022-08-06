using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class phongggg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_nhanViens_nhanViens_MaQuanLi",
                table: "nhanViens");

            migrationBuilder.DropIndex(
                name: "IX_nhanViens_MaQuanLi",
                table: "nhanViens");

            migrationBuilder.DropColumn(
                name: "MaQuanLi",
                table: "nhanViens");

            migrationBuilder.AddColumn<string>(
                name: "QuanLiMaNV",
                table: "nhanViens",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Vaitro",
                table: "nhanViens",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_nhanViens_QuanLiMaNV",
                table: "nhanViens",
                column: "QuanLiMaNV");

            migrationBuilder.AddForeignKey(
                name: "FK_nhanViens_nhanViens_QuanLiMaNV",
                table: "nhanViens",
                column: "QuanLiMaNV",
                principalTable: "nhanViens",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_nhanViens_nhanViens_QuanLiMaNV",
                table: "nhanViens");

            migrationBuilder.DropIndex(
                name: "IX_nhanViens_QuanLiMaNV",
                table: "nhanViens");

            migrationBuilder.DropColumn(
                name: "QuanLiMaNV",
                table: "nhanViens");

            migrationBuilder.DropColumn(
                name: "Vaitro",
                table: "nhanViens");

            migrationBuilder.AddColumn<string>(
                name: "MaQuanLi",
                table: "nhanViens",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_nhanViens_MaQuanLi",
                table: "nhanViens",
                column: "MaQuanLi");

            migrationBuilder.AddForeignKey(
                name: "FK_nhanViens_nhanViens_MaQuanLi",
                table: "nhanViens",
                column: "MaQuanLi",
                principalTable: "nhanViens",
                principalColumn: "MaNV");
        }
    }
}
