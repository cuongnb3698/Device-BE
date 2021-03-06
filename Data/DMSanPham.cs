//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class DMSanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DMSanPham()
        {
            this.DMCartDetails = new HashSet<DMCartDetail>();
            this.DMCauHinhs = new HashSet<DMCauHinh>();
            this.HSCmts = new HashSet<HSCmt>();
        }
    
        public System.Guid Id { get; set; }
        public string Ten { get; set; }
        public string TenNgan { get; set; }
        public string MoTa { get; set; }
        public Nullable<int> Rate { get; set; }
        public Nullable<int> ViewCount { get; set; }
        public Nullable<System.DateTime> ThoiGianTao { get; set; }
        public Nullable<System.DateTime> ThoiGianDong { get; set; }
        public string SeriesNumber { get; set; }
        public string Color { get; set; }
        public Nullable<decimal> Gia { get; set; }
        public Nullable<System.Guid> IdTrangThai { get; set; }
        public Nullable<System.Guid> IdNhaCungCap { get; set; }
        public Nullable<System.Guid> IdAnh { get; set; }
        public Nullable<System.Guid> IdNguoiNhap { get; set; }
        public Nullable<System.Guid> IdKho { get; set; }
        public Nullable<System.Guid> IdLoaiSP { get; set; }
        public Nullable<int> KhuyenMai { get; set; }
    
        public virtual CMTuDien CMTuDien { get; set; }
        public virtual CMTuDien CMTuDien1 { get; set; }
        public virtual DMAnh DMAnh { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DMCartDetail> DMCartDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DMCauHinh> DMCauHinhs { get; set; }
        public virtual DMKho DMKho { get; set; }
        public virtual DMNhaCungCap DMNhaCungCap { get; set; }
        public virtual HTUser HTUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HSCmt> HSCmts { get; set; }
    }
}
