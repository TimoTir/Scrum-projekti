//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Scrum.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kurssit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kurssit()
        {
            this.KurssiToteutukset = new HashSet<KurssiToteutukset>();
            this.Osallistumiset = new HashSet<Osallistumiset>();
        }
    
        public string Kurssi { get; set; }
        public Nullable<int> Laajuus { get; set; }
        public int KurssiId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KurssiToteutukset> KurssiToteutukset { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Osallistumiset> Osallistumiset { get; set; }
    }
}
