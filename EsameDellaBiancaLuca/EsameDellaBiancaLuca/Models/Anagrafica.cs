namespace EsameDellaBiancaLuca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Anagrafica")]
    public partial class Anagrafica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Anagrafica()
        {
            Ticket = new HashSet<Ticket>();
        }

        public int AnagraficaId { get; set; }

        [StringLength(20)]
        public string Cognome { get; set; }

        [StringLength(20)]
        public string Nome { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        public bool? Cliente { get; set; }

        public bool? Interno { get; set; }

        public bool? Fornitore { get; set; }

        [StringLength(4)]
        public string CodiceAnagrafica { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
