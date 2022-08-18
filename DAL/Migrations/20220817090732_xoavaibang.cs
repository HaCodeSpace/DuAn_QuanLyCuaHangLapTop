using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class xoavaibang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "banPhimKeyCaps");

            migrationBuilder.DropTable(
                name: "banPhimSoLuongSwitches");

            migrationBuilder.DropTable(
                name: "sanPhamMauSacs");

            migrationBuilder.DropTable(
                name: "keyCaps");

            migrationBuilder.AlterColumn<string>(
                name: "TenSP",
                table: "sanPhams",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "soluong",
                table: "sanPhams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CPU",
                table: "laptops",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "soluong",
                table: "sanPhams");

            migrationBuilder.AlterColumn<string>(
                name: "TenSP",
                table: "sanPhams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "CPU",
                table: "laptops",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateTable(
                name: "banPhimSoLuongSwitches",
                columns: table => new
                {
                    MaSP = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Switch = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banPhimSoLuongSwitches", x => x.MaSP);
                    table.ForeignKey(
                        name: "FK_banPhimSoLuongSwitches_banPhims_MaSP",
                        column: x => x.MaSP,
                        principalTable: "banPhims",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "keyCaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKeyCaps = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_keyCaps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sanPhamMauSacs",
                columns: table => new
                {
                    Masp = table.Column<int>(type: "int", nullable: false),
                    Idmau = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhamMauSacs", x => new { x.Masp, x.Idmau });
                    table.ForeignKey(
                        name: "FK_sanPhamMauSacs_banPhims_Masp",
                        column: x => x.Masp,
                        principalTable: "banPhims",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamMauSacs_mauSacs_Idmau",
                        column: x => x.Idmau,
                        principalTable: "mauSacs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "banPhimKeyCaps",
                columns: table => new
                {
                    IdKeyCaps = table.Column<int>(type: "int", nullable: false),
                    MaSP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banPhimKeyCaps", x => new { x.IdKeyCaps, x.MaSP });
                    table.ForeignKey(
                        name: "FK_banPhimKeyCaps_banPhims_MaSP",
                        column: x => x.MaSP,
                        principalTable: "banPhims",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_banPhimKeyCaps_keyCaps_IdKeyCaps",
                        column: x => x.IdKeyCaps,
                        principalTable: "keyCaps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_banPhimKeyCaps_MaSP",
                table: "banPhimKeyCaps",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamMauSacs_Idmau",
                table: "sanPhamMauSacs",
                column: "Idmau");
        }
    }
}
