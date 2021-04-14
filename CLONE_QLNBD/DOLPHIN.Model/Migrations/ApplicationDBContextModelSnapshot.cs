﻿// <auto-generated />
using System;
using DOLPHIN.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DOLPHIN.Model.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DOLPHIN.Model.Account", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PassWord")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("DOLPHIN.Model.BienBan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("HienTrang")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("MaToChucDaiDien")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayBanHanh")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("NgayLapBienBan")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("NgayThucHienQuyDinh")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NhanXet")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("SoLanCapNhat")
                        .HasColumnType("int");

                    b.Property<string>("TenBienBan")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ThongTinDonVi")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.Property<string>("YKienDonVi")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("MaToChucDaiDien");

                    b.ToTable("BienBan");
                });

            modelBuilder.Entity("DOLPHIN.Model.CanBo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DiaChi")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DonVi")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TenCanBo")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CanBo");
                });

            modelBuilder.Entity("DOLPHIN.Model.CongTrinhKhaiThac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("LoaiCongTrinh")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("MaCanBoQuanLy")
                        .HasColumnType("int");

                    b.Property<int>("MaGiayPhep")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayThucHien")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("TenCongTrinh")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("ThoiGianDuKien")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaCanBoQuanLy");

                    b.HasIndex("MaGiayPhep");

                    b.ToTable("CongTrinhKhaiThac");
                });

            modelBuilder.Entity("DOLPHIN.Model.DonViHanhChinh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TenDonViHanhChinh")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ToaDo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("DonViHanhChinh");
                });

            modelBuilder.Entity("DOLPHIN.Model.GiayPhepSoGiaHan", b =>
                {
                    b.Property<int>("MaGiayPhep")
                        .HasColumnType("int");

                    b.Property<int>("MaSoGiaHan")
                        .HasColumnType("int");

                    b.HasKey("MaGiayPhep", "MaSoGiaHan");

                    b.HasIndex("MaSoGiaHan");

                    b.ToTable("GiayPhepSoGiaHan");
                });

            modelBuilder.Entity("DOLPHIN.Model.HoSo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("KhoiLuong")
                        .HasColumnType("int");

                    b.Property<int?>("MaToChuc")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayBanHanh")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("NgayThucHienQuyDinh")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("NgayThucHienThucTe")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NoiDung")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("SoLanCapNhat")
                        .HasColumnType("int");

                    b.Property<string>("TenHoSo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaToChuc");

                    b.ToTable("HoSo");
                });

            modelBuilder.Entity("DOLPHIN.Model.HoSoQuet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("MaCanBoThucHien")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayCapNhat")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("NgayThucHien")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NoiDung")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TenHoSo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("MaCanBoThucHien");

                    b.ToTable("HoSoQuet");
                });

            modelBuilder.Entity("DOLPHIN.Model.LoaiChiPhi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayBanHanh")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("NgayCapNhat")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SoTien")
                        .HasColumnType("int");

                    b.Property<string>("TenLoaiChiPhi")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("LoaiChiPhi");
                });

            modelBuilder.Entity("DOLPHIN.Model.MetaData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayCapNhat")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("NgayThucHien")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NoiDung")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TenFile")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("MetaData");
                });

            modelBuilder.Entity("DOLPHIN.Model.QuanTrac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ChatLuongNuoc")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("LuuLuong")
                        .HasColumnType("int");

                    b.Property<int>("MucNuocDong")
                        .HasColumnType("int");

                    b.Property<int>("MucNuocTinh")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("QuanTrac");
                });

            modelBuilder.Entity("DOLPHIN.Model.SoGiaHan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DuongKinh")
                        .HasColumnType("int");

                    b.Property<int>("LuuLuong")
                        .HasColumnType("int");

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ToaDo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SoGiaHan");
                });

            modelBuilder.Entity("DOLPHIN.Model.SoHieu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ChuVietTat")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TenLoaiVanBan")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("SoHieu");
                });

            modelBuilder.Entity("DOLPHIN.Model.SoHieuSoGiaHan", b =>
                {
                    b.Property<int>("MaSoHieu")
                        .HasColumnType("int");

                    b.Property<int>("MaSoGiaHan")
                        .HasColumnType("int");

                    b.HasKey("MaSoHieu", "MaSoGiaHan");

                    b.HasIndex("MaSoGiaHan");

                    b.ToTable("SoHieuSoGiaHan");
                });

            modelBuilder.Entity("DOLPHIN.Model.ThongBao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("LuuLuongKhaiThac")
                        .HasColumnType("int");

                    b.Property<int>("MaLoaiChiPhi")
                        .HasColumnType("int");

                    b.Property<int?>("MaToChuc")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayBanHanh")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("TenThongBao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("MaToChuc");

                    b.ToTable("ThongBao");
                });

            modelBuilder.Entity("DOLPHIN.Model.ToChuc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DiaChi")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("MaNhanVienQuanLy")
                        .HasColumnType("int");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TenToChuc")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("ToChuc");
                });

            modelBuilder.Entity("DOLPHIN.Model.ToChucSoGiaHan", b =>
                {
                    b.Property<int>("MaToChuc")
                        .HasColumnType("int");

                    b.Property<int>("MaSoGiaHan")
                        .HasColumnType("int");

                    b.HasKey("MaToChuc", "MaSoGiaHan");

                    b.HasIndex("MaSoGiaHan");

                    b.ToTable("ToChucSoGiaHan");
                });

            modelBuilder.Entity("DOLPHIN.Model.ToTrinh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("LuongNuocKhaiThac")
                        .HasColumnType("int");

                    b.Property<int>("MaDonViHanhChinh")
                        .HasColumnType("int");

                    b.Property<int>("MaQuanTrac")
                        .HasColumnType("int");

                    b.Property<int>("MaToChuc")
                        .HasColumnType("int");

                    b.Property<string>("MucDichKhaiThac")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("NgayBanHanh")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SoGieng")
                        .HasColumnType("int");

                    b.Property<int>("SoLanCapNhat")
                        .HasColumnType("int");

                    b.Property<int>("TangChuaNuocKhaiThac")
                        .HasColumnType("int");

                    b.Property<string>("TenToTrinh")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("ThoiHanCapPhep")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaDonViHanhChinh");

                    b.HasIndex("MaQuanTrac");

                    b.HasIndex("MaToChuc");

                    b.ToTable("ToTrinh");
                });

            modelBuilder.Entity("DOLPHIN.Model.BienBan", b =>
                {
                    b.HasOne("DOLPHIN.Model.ToChuc", "ToChuc")
                        .WithMany()
                        .HasForeignKey("MaToChucDaiDien");
                });

            modelBuilder.Entity("DOLPHIN.Model.CongTrinhKhaiThac", b =>
                {
                    b.HasOne("DOLPHIN.Model.CanBo", "CanBo")
                        .WithMany()
                        .HasForeignKey("MaCanBoQuanLy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DOLPHIN.Model.ToTrinh", "ToTrinh")
                        .WithMany()
                        .HasForeignKey("MaGiayPhep")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DOLPHIN.Model.GiayPhepSoGiaHan", b =>
                {
                    b.HasOne("DOLPHIN.Model.ToTrinh", "GiayPhep")
                        .WithMany("GiayPhepSoGiaHan")
                        .HasForeignKey("MaGiayPhep")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DOLPHIN.Model.SoGiaHan", "SoGiaHan")
                        .WithMany("GiayPhepSoGiaHan")
                        .HasForeignKey("MaSoGiaHan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DOLPHIN.Model.HoSo", b =>
                {
                    b.HasOne("DOLPHIN.Model.ToChuc", "ToChuc")
                        .WithMany()
                        .HasForeignKey("MaToChuc");
                });

            modelBuilder.Entity("DOLPHIN.Model.HoSoQuet", b =>
                {
                    b.HasOne("DOLPHIN.Model.CanBo", "CanBo")
                        .WithMany()
                        .HasForeignKey("MaCanBoThucHien");
                });

            modelBuilder.Entity("DOLPHIN.Model.SoHieuSoGiaHan", b =>
                {
                    b.HasOne("DOLPHIN.Model.SoGiaHan", "SoGiaHan")
                        .WithMany("SoHieuSoGiaHan")
                        .HasForeignKey("MaSoGiaHan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DOLPHIN.Model.SoHieu", "SoHieu")
                        .WithMany("SoHieuSoGiaHan")
                        .HasForeignKey("MaSoHieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DOLPHIN.Model.ThongBao", b =>
                {
                    b.HasOne("DOLPHIN.Model.ToChuc", "ToChuc")
                        .WithMany()
                        .HasForeignKey("MaToChuc");
                });

            modelBuilder.Entity("DOLPHIN.Model.ToChucSoGiaHan", b =>
                {
                    b.HasOne("DOLPHIN.Model.SoGiaHan", "SoGiaHan")
                        .WithMany("ToChucSoGiaHan")
                        .HasForeignKey("MaSoGiaHan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DOLPHIN.Model.ToChuc", "ToChuc")
                        .WithMany("ToChucSoGiaHan")
                        .HasForeignKey("MaToChuc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DOLPHIN.Model.ToTrinh", b =>
                {
                    b.HasOne("DOLPHIN.Model.DonViHanhChinh", "DonViHanhChinh")
                        .WithMany()
                        .HasForeignKey("MaDonViHanhChinh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DOLPHIN.Model.QuanTrac", "QuanTrac")
                        .WithMany()
                        .HasForeignKey("MaQuanTrac")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DOLPHIN.Model.ToChuc", "ToChuc")
                        .WithMany()
                        .HasForeignKey("MaToChuc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
