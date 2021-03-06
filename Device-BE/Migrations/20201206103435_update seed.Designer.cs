﻿// <auto-generated />
using System;
using Device_BE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Device_BE.Migrations
{
    [DbContext(typeof(DeviceContext))]
    [Migration("20201206103435_update seed")]
    partial class updateseed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Device_BE.Models.MDevice.CMLoaiTuDien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("CMLoaiTuDien");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.CMTuDien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<Guid?>("IdLoaiTuDien")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaTuDien")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("TenNgan")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("UuTien")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdLoaiTuDien");

                    b.ToTable("CMTuDien");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMAnh", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid?>("IdLoaiAnh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("UuTien")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdLoaiAnh");

                    b.ToTable("DMAnh");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMBaoCao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ThuTuc")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("TieuDe")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("DMBaoCao");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMCart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdLoaiGD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdTrangThai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ThoiGianTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("TinNhan")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<decimal?>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IdLoaiGD");

                    b.HasIndex("IdTrangThai");

                    b.HasIndex("UserId");

                    b.ToTable("DMCart");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMCartDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ThoiGianTao")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UuTien")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdSanPham");

                    b.ToTable("DMCartDetail");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMCauHinh", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CPU")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("DungLuong")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<Guid?>("IdLoaiCauHinh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ManHinh")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("NgaySX")
                        .HasColumnType("datetime2");

                    b.Property<string>("PIN")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("RAM")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int?>("ThoiGianBaoHanh")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdLoaiCauHinh");

                    b.ToTable("DMCauHinh");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMChiNhanh", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("ThoiGianTao")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UuTien")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DMChiNhanh");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMDiaChi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<Guid?>("IdLoaiDiaChi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IdLoaiDiaChi");

                    b.HasIndex("UserId");

                    b.ToTable("DMDiaChi");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMKho", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid?>("IdChiNhanh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("DMKho");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMNhaCungCap", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Active")
                        .HasColumnType("bit")
                        .HasMaxLength(250);

                    b.Property<string>("Anh")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Sdt")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("ThoiGianTao")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("DMNhaCungCap");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMPhongBan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid?>("IdChiNhanh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IdChiNhanh");

                    b.HasIndex("UserId");

                    b.ToTable("DMPhongBan");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMSanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("IdAnh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdCauHinh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdKho")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdLoaiSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdNguoiNhap")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdNhaCungCap")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdTrangThai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("KhuyenMai")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("SeriesNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("TenNgan")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("ThoiGianDong")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ThoiGianTao")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdAnh");

                    b.HasIndex("IdCauHinh");

                    b.HasIndex("IdKho");

                    b.HasIndex("IdLoaiSP");

                    b.HasIndex("IdNguoiNhap");

                    b.HasIndex("IdNhaCungCap");

                    b.HasIndex("IdTrangThai");

                    b.ToTable("DMSanPham");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMTinhThanh", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid?>("IdCapTren")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdLoaiTinhThanh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("UuTien")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdLoaiTinhThanh");

                    b.ToTable("DMTinhThanh");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.HSCmt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid?>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ThoiGianTao")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IdSanPham");

                    b.HasIndex("UserId");

                    b.ToTable("HSCmt");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.HSTinNhan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid?>("IdTrangThai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ThoiGianTao")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IdTrangThai");

                    b.HasIndex("UserId");

                    b.ToTable("HSTinNhan");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.HSTraLoiCmt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid?>("IdCmt")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(220)")
                        .HasMaxLength(220);

                    b.Property<DateTime?>("ThoiGianTao")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdCmt");

                    b.ToTable("HSTraLoiCmt");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.HSTraLoiTinNhan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid?>("IdTinNhan")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("ThoiGianTao")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Watched")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdTinNhan");

                    b.ToTable("HSTraLoiTinNhan");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.HTMenu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Controller")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<Guid>("IdParent")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("HTMenu");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.HTRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("HTRole");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9b76ed13-ce77-4d41-0908-08d8223497a3"),
                            Code = "giamdoc",
                            MoTa = "GIAMDOC",
                            Ten = "Giám Đốc"
                        },
                        new
                        {
                            Id = new Guid("9b76ed13-ce77-4d41-0908-08d5423497a3"),
                            Code = "admin",
                            MoTa = "ADMIN",
                            Ten = "admin"
                        },
                        new
                        {
                            Id = new Guid("9b76ed13-ce77-4d41-0908-08d8123497a3"),
                            Code = "nhanvien",
                            MoTa = "ADMIN",
                            Ten = "Nhân viên"
                        },
                        new
                        {
                            Id = new Guid("9b76ed13-ce77-4d41-0908-08d8223497a8"),
                            Code = "khachhang",
                            MoTa = "Khách hàng",
                            Ten = "Khách hàng"
                        });
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.HTRoleMenu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdMenu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdRole")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int?>("UuTien")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMenu");

                    b.HasIndex("IdRole");

                    b.ToTable("HTRoleMenu");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.HTUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<Guid?>("IdAnh")
                        .HasColumnType("uniqueidentifier")
                        .HasMaxLength(220);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sdt")
                        .HasColumnType("nvarchar(22)")
                        .HasMaxLength(22);

                    b.Property<string>("TenKhongDau")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("Tuoi")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("HTUser");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9b76ed13-ce77-4d41-0908-08d0223497a3"),
                            Active = true,
                            CreateDate = new DateTime(2020, 12, 6, 17, 34, 35, 293, DateTimeKind.Local).AddTicks(6487),
                            DiaChi = "Hà Nội",
                            Email = "cuong@gmail.com",
                            HoTen = "ad CườngNB",
                            PasswordHash = "8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918",
                            TenKhongDau = "nbc",
                            Tuoi = 22,
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("9b76ed13-ce77-4d41-0908-08d0223497b2"),
                            Active = true,
                            CreateDate = new DateTime(2020, 12, 6, 17, 34, 35, 294, DateTimeKind.Local).AddTicks(7096),
                            DiaChi = "Hà Nội",
                            Email = "cuong@gmail.com",
                            HoTen = "KH",
                            PasswordHash = "8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918",
                            TenKhongDau = "nbc",
                            Tuoi = 22,
                            Username = "cuong"
                        });
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.HTUserRole", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("HTUserRole");

                    b.HasData(
                        new
                        {
                            RoleId = new Guid("9b76ed13-ce77-4d41-0908-08d5423497a3"),
                            UserId = new Guid("9b76ed13-ce77-4d41-0908-08d0223497a3")
                        },
                        new
                        {
                            RoleId = new Guid("9b76ed13-ce77-4d41-0908-08d8223497a8"),
                            UserId = new Guid("9b76ed13-ce77-4d41-0908-08d0223497b2")
                        });
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.CMTuDien", b =>
                {
                    b.HasOne("Device_BE.Models.MDevice.CMLoaiTuDien", "CMLoaiTuDien")
                        .WithMany()
                        .HasForeignKey("IdLoaiTuDien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMAnh", b =>
                {
                    b.HasOne("Device_BE.Models.MDevice.CMTuDien", "CMTuDien")
                        .WithMany()
                        .HasForeignKey("IdLoaiAnh");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMCart", b =>
                {
                    b.HasOne("Device_BE.Models.MDevice.CMTuDien", "CMTuDien1")
                        .WithMany()
                        .HasForeignKey("IdLoaiGD");

                    b.HasOne("Device_BE.Models.MDevice.CMTuDien", "CMTuDien2")
                        .WithMany()
                        .HasForeignKey("IdTrangThai");

                    b.HasOne("Device_BE.Models.MDevice.HTUser", "HTUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMCartDetail", b =>
                {
                    b.HasOne("Device_BE.Models.MDevice.DMSanPham", "DMSanPham")
                        .WithMany()
                        .HasForeignKey("IdSanPham");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMCauHinh", b =>
                {
                    b.HasOne("Device_BE.Models.MDevice.CMTuDien", "CMTuDien")
                        .WithMany()
                        .HasForeignKey("IdLoaiCauHinh");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMDiaChi", b =>
                {
                    b.HasOne("Device_BE.Models.MDevice.CMTuDien", "CMTuDien")
                        .WithMany()
                        .HasForeignKey("IdLoaiDiaChi");

                    b.HasOne("Device_BE.Models.MDevice.HTUser", "HTUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMPhongBan", b =>
                {
                    b.HasOne("Device_BE.Models.MDevice.DMChiNhanh", "dMChiNhanh")
                        .WithMany()
                        .HasForeignKey("IdChiNhanh");

                    b.HasOne("Device_BE.Models.MDevice.HTUser", "HTUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMSanPham", b =>
                {
                    b.HasOne("Device_BE.Models.MDevice.DMAnh", "DMAnh")
                        .WithMany()
                        .HasForeignKey("IdAnh");

                    b.HasOne("Device_BE.Models.MDevice.DMCauHinh", "DMCauHinh")
                        .WithMany()
                        .HasForeignKey("IdCauHinh");

                    b.HasOne("Device_BE.Models.MDevice.DMKho", "DMKho")
                        .WithMany()
                        .HasForeignKey("IdKho");

                    b.HasOne("Device_BE.Models.MDevice.CMTuDien", "CMTuDien1")
                        .WithMany()
                        .HasForeignKey("IdLoaiSP");

                    b.HasOne("Device_BE.Models.MDevice.HTUser", "HTUser")
                        .WithMany()
                        .HasForeignKey("IdNguoiNhap");

                    b.HasOne("Device_BE.Models.MDevice.DMNhaCungCap", "DMNhaCungCap")
                        .WithMany()
                        .HasForeignKey("IdNhaCungCap");

                    b.HasOne("Device_BE.Models.MDevice.CMTuDien", "CMTuDien")
                        .WithMany()
                        .HasForeignKey("IdTrangThai");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.DMTinhThanh", b =>
                {
                    b.HasOne("Device_BE.Models.MDevice.CMTuDien", "CMTuDien")
                        .WithMany()
                        .HasForeignKey("IdLoaiTinhThanh");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.HSCmt", b =>
                {
                    b.HasOne("Device_BE.Models.MDevice.DMSanPham", "DMSanPham")
                        .WithMany()
                        .HasForeignKey("IdSanPham");

                    b.HasOne("Device_BE.Models.MDevice.HTUser", "HTUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.HSTinNhan", b =>
                {
                    b.HasOne("Device_BE.Models.MDevice.CMTuDien", "CMTuDien")
                        .WithMany()
                        .HasForeignKey("IdTrangThai");

                    b.HasOne("Device_BE.Models.MDevice.HTUser", "HTUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.HSTraLoiCmt", b =>
                {
                    b.HasOne("Device_BE.Models.MDevice.HSCmt", "HSCmt")
                        .WithMany()
                        .HasForeignKey("IdCmt");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.HSTraLoiTinNhan", b =>
                {
                    b.HasOne("Device_BE.Models.MDevice.HSTinNhan", "HSTinNhan")
                        .WithMany()
                        .HasForeignKey("IdTinNhan");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.HTRoleMenu", b =>
                {
                    b.HasOne("Device_BE.Models.MDevice.HTMenu", "HTMenu")
                        .WithMany()
                        .HasForeignKey("IdMenu");

                    b.HasOne("Device_BE.Models.MDevice.HTRole", "HTRole")
                        .WithMany()
                        .HasForeignKey("IdRole");
                });

            modelBuilder.Entity("Device_BE.Models.MDevice.HTUserRole", b =>
                {
                    b.HasOne("Device_BE.Models.MDevice.HTRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Device_BE.Models.MDevice.HTUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
