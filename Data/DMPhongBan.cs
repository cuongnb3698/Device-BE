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
    
    public partial class DMPhongBan
    {
        public System.Guid Id { get; set; }
        public string Ten { get; set; }
        public Nullable<System.Guid> IdChiNhanh { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual DMChiNhanh DMChiNhanh { get; set; }
        public virtual HTUser HTUser { get; set; }
    }
}