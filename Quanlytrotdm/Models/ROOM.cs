//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quanlytrotdm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ROOM
    {
        public int ID { get; set; }
        public string TITLEROOM { get; set; }
        public Nullable<int> IDMOTEL { get; set; }
        public Nullable<int> PRICE { get; set; }
        public string ADDRESS { get; set; }
        public string INFORMATION { get; set; }
        public string CONTACT { get; set; }
        public Nullable<int> EVALUATE { get; set; }
        public string HINHANH { get; set; }
        public Nullable<System.DateTime> NGAYDANG { get; set; }
    
        public virtual MOTEL MOTEL { get; set; }
    }
}
