//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgendaCourtier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customers()
        {
            this.Appointments = new HashSet<Appointments>();
        }
    
        public int idCustomer { get; set; }

        [Required(ErrorMessage = "Entrez son Nom")]
        [Display(Name = "Nom")]
        public string lastname { get; set; }

        [Required(ErrorMessage = "Entrez son prenom")]
        [Display(Name = "Prénom")]
        public string firstname { get; set; }

        [Required(ErrorMessage = "Entrez une adresse mail complete")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string mail { get; set; }

        [Required(ErrorMessage = "Entrez son numero")]
        [MinLength(10, ErrorMessage = "Entrez un numero telephone valide")]
        [Phone]
        [Display(Name = "N° Mobile")]
        public string phoneNumber { get; set; }

        [Required(ErrorMessage = "Entrez le Budget")]
        [Display(Name = "Budget")]
        public int budget { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Appointments> Appointments { get; set; }
    }
}