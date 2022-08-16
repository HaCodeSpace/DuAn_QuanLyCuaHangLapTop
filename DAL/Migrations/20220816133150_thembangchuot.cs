using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class thembangchuot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chuots",
                columns: table => new
                {
                    MaChuot = table.Column<int>(type: "int", nullable: false),
                    KetNoi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IPS = table.Column<int>(type: "int", nullable: false),
                    TanSoPhanHoi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChetLieuVo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrongLuong = table.Column<double>(type: "float", nullable: false),
                    Switch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Led = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaToc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KichThuoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TuoiTho = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chuots", x => x.MaChuot);
                    table.ForeignKey(
                        name: "FK_chuots_sanPhams_MaChuot",
                        column: x => x.MaChuot,
                        principalTable: "sanPhams",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chuots");
        }
    }
}
