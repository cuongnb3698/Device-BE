﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLSTOREEntities : DbContext
    {
        public QLSTOREEntities()
            : base("name=QLSTOREEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CMLoaiTuDien> CMLoaiTuDiens { get; set; }
        public virtual DbSet<CMTuDien> CMTuDiens { get; set; }
        public virtual DbSet<DMAnh> DMAnhs { get; set; }
        public virtual DbSet<DMBaoCao> DMBaoCaos { get; set; }
        public virtual DbSet<DMCart> DMCarts { get; set; }
        public virtual DbSet<DMCartDetail> DMCartDetails { get; set; }
        public virtual DbSet<DMCauHinh> DMCauHinhs { get; set; }
        public virtual DbSet<DMChiNhanh> DMChiNhanhs { get; set; }
        public virtual DbSet<DMKho> DMKhoes { get; set; }
        public virtual DbSet<DMNhaCungCap> DMNhaCungCaps { get; set; }
        public virtual DbSet<DMPhongBan> DMPhongBans { get; set; }
        public virtual DbSet<DMSanPham> DMSanPhams { get; set; }
        public virtual DbSet<DMTinhThanh> DMTinhThanhs { get; set; }
        public virtual DbSet<HSCmt> HSCmts { get; set; }
        public virtual DbSet<HSTinNhan> HSTinNhans { get; set; }
        public virtual DbSet<HSTraLoiCmt> HSTraLoiCmts { get; set; }
        public virtual DbSet<HSTraLoiTinNhan> HSTraLoiTinNhans { get; set; }
        public virtual DbSet<HTMenu> HTMenus { get; set; }
        public virtual DbSet<HTRole> HTRoles { get; set; }
        public virtual DbSet<HTRoleMenu> HTRoleMenus { get; set; }
        public virtual DbSet<HTUser> HTUsers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}