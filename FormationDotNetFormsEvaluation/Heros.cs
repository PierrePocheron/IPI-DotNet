//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormationDotNetFormsEvaluation
{
    using System;
    using System.Collections.Generic;
    
    public partial class Heros
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Heros()
        {
            this.Inventaire = new HashSet<Inventaire>();
        }
    
        public int id_hero { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string specialite { get; set; }
        public string classe { get; set; }
        public Nullable<int> lvl { get; set; }
        public Nullable<int> puissance { get; set; }
        public Nullable<int> nbMissionReussi { get; set; }
        public Nullable<int> reputation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventaire> Inventaire { get; set; }
    }
}