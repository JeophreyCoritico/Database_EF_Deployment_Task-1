//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SVS_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class C102575814Procedure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C102575814Procedure()
        {
            this.C102575814Treatment = new HashSet<C102575814Treatment>();
        }
    
        public int ProcedureID { get; set; }
        public string Description { get; set; }
        public Nullable<int> Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C102575814Treatment> C102575814Treatment { get; set; }
    }
}
