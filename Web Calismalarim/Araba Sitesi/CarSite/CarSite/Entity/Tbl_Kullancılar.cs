//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarSite.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Kullancılar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Kullancılar()
        {
            this.Tbl_Ilanlar = new HashSet<Tbl_Ilanlar>();
        }
    
        public int ID { get; set; }
        public string KAD { get; set; }
        public string PASS { get; set; }
        public string ADI { get; set; }
        public string SOYADI { get; set; }
        public string MAIL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Ilanlar> Tbl_Ilanlar { get; set; }
    }
}
