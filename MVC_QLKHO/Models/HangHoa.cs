//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_QLKHO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HangHoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HangHoa()
        {
            this.LoHangs = new HashSet<LoHang>();
        }
    
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public string MoTa { get; set; }
        public string ID_NHH { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<int> SoLuongTon { get; set; }
    
        public virtual NhomHangHoa NhomHangHoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoHang> LoHangs { get; set; }
    }
}
