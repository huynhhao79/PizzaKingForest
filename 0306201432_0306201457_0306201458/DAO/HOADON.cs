//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            this.CT_HOADON = new HashSet<CT_HOADON>();
        }
    
        public string MaHD { get; set; }
        public string MaNV { get; set; }
        public string GhiChu { get; set; }
        public Nullable<System.DateTime> NgayLapHD { get; set; }
        public Nullable<decimal> Tong { get; set; }
        public Nullable<int> TrangThai { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOADON> CT_HOADON { get; set; }
    }
}
