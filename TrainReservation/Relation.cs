//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrainReservation
{
    using System;
    using System.Collections.Generic;
    
    public partial class Relation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Relation()
        {
            this.Ticket = new HashSet<Ticket>();
            this.Ticket1 = new HashSet<Ticket>();
        }
    
        public int Id_relation { get; set; }
        public int Id_station { get; set; }
        public Nullable<double> Distance { get; set; }
        public Nullable<System.DateTime> TimeCome { get; set; }
        public Nullable<System.DateTime> TimeLeave { get; set; }
        public int NumberStation { get; set; }
        public int Nr_line { get; set; }
        public int Nr_relation { get; set; }
    
        public virtual Station Station { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Ticket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Ticket1 { get; set; }
    }
}