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
    
    public partial class Tbl_Marka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Marka()
        {
            this.Tbl_Ilanlar = new HashSet<Tbl_Ilanlar>();
            this.Tbl_Modeller = new HashSet<Tbl_Modeller>();
        }
    
        public int MARKAID { get; set; }
        public string MARKA_ADI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Ilanlar> Tbl_Ilanlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Modeller> Tbl_Modeller { get; set; }
    }
}
