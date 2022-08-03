using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Model;

namespace DAL.DatabaseContext
{
    public class DA1Context : DbContext
    {
        public virtual DbSet<NhanVien> nhanViens { get; set; }
        DbSet<HoaDon> hoaDons { get; set; }
        public virtual DbSet<KhachHang> khachHangs { get; set; }
        DbSet<HoaDonChiTiet> hoaDonChiTiets { get; set; }
        DbSet<KhuyenMai> khuyenMais { get; set; }
        public virtual DbSet<SanPham> sanPhams { get; set; }
        public virtual DbSet<BanPhim> banPhims { get; set; }
        DbSet<BanPhimSoLuongSwitch> banPhimSoLuongSwitches { get; set; }
        DbSet<MauSac> mauSacs { get; set; }
        DbSet<SanPhamMauSac> sanPhamMauSacs { get; set; }
        DbSet<KeyCaps> keyCaps { get; set; }
        DbSet<BanPhimKeyCaps> banPhimKeyCaps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region nhanvien 
            modelBuilder.Entity<NhanVien>().HasKey(nv => nv.MaNV);
            // tạo quan hệ bảng nhân viên tự trỏ chính nó 
            modelBuilder.Entity<NhanVien>()
                .HasOne(nv => nv.QuanLi)
                .WithMany(nv => nv.nhanViens)
                .HasForeignKey(nv => nv.MaQuanLi);
            // tạo quan hệ với bảng hoá đơn 1 - n
            modelBuilder.Entity<NhanVien>()
                .HasMany<HoaDon>(nv => nv.hoaDons)
                .WithOne(hd => hd.NhanVien)
                .HasForeignKey(hd => hd.MaNV);
            #endregion

            #region HoaDon 
            modelBuilder.Entity<HoaDon>().HasKey(hd => hd.MaHD);
            // tạo quan hệ với bảng hoá đơn chi tiết 1 - n
            modelBuilder.Entity<HoaDon>()
                .HasMany<HoaDonChiTiet>(hd => hd.hoadonchitiets)
                .WithOne(hdct => hdct.hoaDon)
                .HasForeignKey(hdct => hdct.MaHD);
            #endregion

            #region KhachHang
            modelBuilder.Entity<KhachHang>().HasKey(kh => kh.MaKH);
            // tạo quan hệ với bảng hoá đơn 1 - n
            modelBuilder.Entity<KhachHang>()
                .HasMany<HoaDon>(kh => kh.hoaDons)
                .WithOne(hd => hd.khachHang)
                .HasForeignKey(hd => hd.MaKH);
            #endregion

            #region HoaDonChiTiet
            modelBuilder.Entity<HoaDonChiTiet>().HasKey(hdct => new { hdct.MaHD, hdct.MaSP });
            #endregion

            #region KhuyenMai
            modelBuilder.Entity<KhuyenMai>().HasKey(km => km.MaKM);
            // tạp quan hệ với bảng hoá đơn 1 - n
            modelBuilder.Entity<KhuyenMai>()
                .HasMany(km => km.hoaDons)
                .WithOne(hd => hd.khuyenMai)
                .HasForeignKey(hd => hd.MaKM);
            #endregion

            #region SanPham
            modelBuilder.Entity<SanPham>().HasKey(sp => sp.MaSP);
            // tạo quan hệ 1 -n với bảng hoadonchitiets
            modelBuilder.Entity<SanPham>()
                .HasMany(sp => sp.hoaDonChiTiets)
                .WithOne(hdct => hdct.sanPham)
                .HasForeignKey(hdct => hdct.MaSP);
            // tạo quan hệ 1 - 1 với bảng bàn phím
            modelBuilder.Entity<SanPham>()
                .HasOne(sp => sp.banPhim)
                .WithOne(bp => bp.sanPham)
                .HasForeignKey<BanPhim>(bp => bp.MaSP);
            #endregion

            #region BanPhim
            modelBuilder.Entity<BanPhim>().HasKey(bp => bp.MaSP);
            // tạo quan hệ 1 - n với bảng banphimsoluongswitch
            modelBuilder.Entity<BanPhim>()
                .HasMany(bp => bp.banPhimSoLuongSwitches)
                .WithOne(bpsls => bpsls.banPhim)
                .HasForeignKey(bpsls => bpsls.MaSP);
            // tạo quan hệ 1 -n với bảng sanphammausac
            modelBuilder.Entity<BanPhim>()
                .HasMany<SanPhamMauSac>(bp => bp.sanPhamMauSacs)
                .WithOne(spms => spms.banPhim)
                .HasForeignKey(spms => spms.MaSP);
            // tạo quan hệ 1 - n với bảng BanPhimKeyCaps
            modelBuilder.Entity<BanPhim>()
                .HasMany<BanPhimKeyCaps>(bp => bp.banPhimKeyCaps)
                .WithOne(bpkcs => bpkcs.banPhim)
                .HasForeignKey(bpkcs => bpkcs.MaSP);
            #endregion

            #region banphimsoluongswitch
            modelBuilder.Entity<BanPhimSoLuongSwitch>().HasKey(bpsls => bpsls.MaSP);
            #endregion

            #region MauSac
            modelBuilder.Entity<MauSac>().HasKey(ms => ms.Id);
            // tạo quan hệ 1 - n với bảng sanphammausac
            modelBuilder.Entity<MauSac>()
                .HasMany<SanPhamMauSac>(ms => ms.sanPhamMauSacs)
                .WithOne(spms => spms.mauSac)
                .HasForeignKey(spms => spms.IdMau);
            #endregion

            #region keycaps
            modelBuilder.Entity<KeyCaps>().HasKey(kcs => kcs.Id);
            // tạo quan hệ 1 - n với bảng BanPhimKeyCaps
            modelBuilder.Entity<KeyCaps>()
                .HasMany<BanPhimKeyCaps>(kcs => kcs.banPhimKeyCaps)
                .WithOne(bpkcs => bpkcs.keyCaps)
                .HasForeignKey(bpkcs => bpkcs.IdKeyCaps);
            #endregion

            #region banphimkeycaps
            modelBuilder.Entity<BanPhimKeyCaps>().HasKey(bpkcs => new { bpkcs.IdKeyCaps, bpkcs.MaSP });
            #endregion

            #region SanphamMauSac
            modelBuilder.Entity<SanPhamMauSac>().HasKey(spms => new { spms.MaSP, spms.IdMau });
            #endregion
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //lưu ý chỉ cần thay tên  ở Data Source= tên servername ở máy tính của bạn và phần catalog là tên đb bạn muốn đặt

                // dòng của người nào người đó dùng lần sau chỉ việc uncomment là được đỡ phải thay đổi của nhau gây mất thời gian
                // sửa đi sửa lại
                // của tuấn anh
               // optionsBuilder.UseSqlServer("Data Source=TUANANHPC\\SQLEXPRESS01;Initial Catalog=DBDuAn1;Persist Security Info=True;User ID=tuananh;Password=123");
                // của a phong
               // optionsBuilder.UseSqlServer(@"Data Source=PHONGTT2710\SQLEXPRESS;Initial Catalog=DBDuAn1;Persist Security Info=True;User ID=phong;Password=123");
                // của hà
               optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-2H8Q06GG\MAIN;Initial Catalog=DBDuAn1;Persist Security Info=True;User ID=ha;Password=123");
                // của hưng
                //optionsBuilder.UseSqlServer("Data Source=;Initial Catalog=DBDuAn1;Persist Security Info=True;User ID=;Password=");

            }
        }
    }
}
