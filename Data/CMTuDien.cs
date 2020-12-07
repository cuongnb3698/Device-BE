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
    
    public partial class CMTuDien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CMTuDien()
        {
            this.DMAnhs = new HashSet<DMAnh>();
            this.DMCarts = new HashSet<DMCart>();
            this.DMCarts1 = new HashSet<DMCart>();
            this.DMCauHinhs = new HashSet<DMCauHinh>();
            this.DMSanPhams = new HashSet<DMSanPham>();
            this.DMSanPhams1 = new HashSet<DMSanPham>();
            this.DMTinhThanhs = new HashSet<DMTinhThanh>();
            this.HSTinNhans = new HashSet<HSTinNhan>();
            this.HTUsers = new HashSet<HTUser>();
        }
    
        public System.Guid Id { get; set; }
        public string MaTuDien { get; set; }
        public Nullable<System.Guid> IdLoaiTuDien { get; set; }
        public string TenNgan { get; set; }
        public string Ten { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> UuTien { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual CMLoaiTuDien CMLoaiTuDien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DMAnh> DMAnhs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DMCart> DMCarts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DMCart> DMCarts1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DMCauHinh> DMCauHinhs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DMSanPham> DMSanPhams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DMSanPham> DMSanPhams1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DMTinhThanh> DMTinhThanhs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HSTinNhan> HSTinNhans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HTUser> HTUsers { get; set; }
    }
}