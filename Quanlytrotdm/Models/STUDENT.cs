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
    
    public partial class STUDENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STUDENT()
        {
            this.MESSEGERs = new HashSet<MESSEGER>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public Nullable<int> AGE { get; set; }
        public string ADDRESS { get; set; }
        public string PHONE { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string SEX { get; set; }
        public string AVATAR { get; set; }
        public Nullable<System.DateTime> DATEBIRD { get; set; }
        public string HANDLE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MESSEGER> MESSEGERs { get; set; }
    }
}
