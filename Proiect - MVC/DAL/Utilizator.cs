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
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Utilizator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Utilizator()
        {
            this.Client = new HashSet<Client>();
            this.Tehnician = new HashSet<Tehnician>();
        }
    
        public int id { get; set; }
        [Required(ErrorMessage = "Numele de utilizator este obligatoriu!")]
        [Display(Name = "Nume utilizator")]
        public string nume_utilizator { get; set; }
        [Required(ErrorMessage = "Parola este obligatorie!")]
        [Display(Name = "Parola")]
        
        public string parola { get; set; }
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Adresa de email nu este valida!")]
        public string email { get; set; }
        public Nullable<int> id_Rol { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client> Client { get; set; }
        public virtual Rol Rol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tehnician> Tehnician { get; set; }
    }
}
