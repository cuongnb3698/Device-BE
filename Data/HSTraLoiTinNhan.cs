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
    
    public partial class HSTraLoiTinNhan
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> IdTinNhan { get; set; }
        public string NoiDung { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> ThoiGianTao { get; set; }
        public Nullable<bool> Watched { get; set; }
    
        public virtual HSTinNhan HSTinNhan { get; set; }
    }
}
