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
    
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            this.CT_HOADON = new HashSet<CT_HOADON>();
        }
    
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string MaLoaiSP { get; set; }
        public string DeBanh { get; set; }
        public string KichCo { get; set; }
        public string MoTa { get; set; }
        public string AnhSP { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public Nullable<int> TrangThai { get; set; }
    
        public virtual LOAISANPHAM LOAISANPHAM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOADON> CT_HOADON { get; set; }
    }
}
