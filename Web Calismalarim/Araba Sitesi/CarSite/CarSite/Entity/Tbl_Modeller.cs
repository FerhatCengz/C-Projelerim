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
    
    public partial class Tbl_Modeller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Modeller()
        {
            this.Tbl_Ilanlar = new HashSet<Tbl_Ilanlar>();
        }
    
        public int MODELID { get; set; }
        public Nullable<int> MRKAID { get; set; }
        public string MODELADI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Ilanlar> Tbl_Ilanlar { get; set; }
        public virtual Tbl_Marka Tbl_Marka { get; set; }
    }
}
