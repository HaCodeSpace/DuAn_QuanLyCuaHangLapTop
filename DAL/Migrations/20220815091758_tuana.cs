using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class tuana : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "laptops",
                columns: table => new
                {
                    MaLaptop = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VGA_Card = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OCung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrongLuong = table.Column<double>(type: "float", nullable: false),
                    ManHinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoPhanGiai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebCam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeDieuHanh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KichThuoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bluetooth = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_laptops", x => x.MaLaptop);
                    table.ForeignKey(
                        name: "FK_laptops_sanPhams_MaLaptop",
                        column: x => x.MaLaptop,
                        principalTable: "sanPhams",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "laptops");
        }
    }
}
