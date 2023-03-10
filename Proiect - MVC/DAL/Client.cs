//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proiect___MVC.DAL
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Programare = new HashSet<Programare>();
        }
    
        public int id { get; set; }
        [Required(ErrorMessage = "Numele este obligatoriu!")]
        [Display(Name = "Client")]
        public string Nume { get; set; }
        [Display(Name = "Utilizator")]
        public Nullable<int> id_Utilizator { get; set; }
    
        public virtual Utilizator Utilizator { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Programare> Programare { get; set; }
    }
}
