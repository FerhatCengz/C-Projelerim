//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OGRENCINOTMVC.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Kulupler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Kulupler()
        {
            this.Tbl_Ogrenci = new HashSet<Tbl_Ogrenci>();
        }
    
        public byte KULUPID { get; set; }
        public string KULUPADI { get; set; }
        public Nullable<short> KULUPKONTENJAN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Ogrenci> Tbl_Ogrenci { get; set; }
    }
}
