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
    
    public partial class Tbl_Ilanlar
    {
        public int KAD_ID { get; set; }
        public Nullable<int> SATAN_KULLANICI { get; set; }
        public string RESIM { get; set; }
        public Nullable<System.DateTime> ILAN_TARIHI { get; set; }
        public Nullable<int> MARKA { get; set; }
        public Nullable<int> MODEL { get; set; }
        public string ARAC_YILI { get; set; }
        public string KM { get; set; }
        public string YAKIT_TURU { get; set; }
        public string VITES_TIPI { get; set; }
        public string MOTOR_HACMI { get; set; }
        public string MOTOR_GUCU { get; set; }
        public string KIMDEN { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<decimal> FİYAT { get; set; }
    
        public virtual Tbl_Kullancılar Tbl_Kullancılar { get; set; }
        public virtual Tbl_Marka Tbl_Marka { get; set; }
        public virtual Tbl_Modeller Tbl_Modeller { get; set; }
    }
}
