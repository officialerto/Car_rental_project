//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace staj_son.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class arac_iade
    {
        public int id { get; set; }
        public string plaka { get; set; }
        public Nullable<int> musteri_id { get; set; }
        public Nullable<System.DateTime> tarih { get; set; }
        public Nullable<int> gecikme { get; set; }
        public Nullable<int> ceza { get; set; }
    }
}