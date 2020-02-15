namespace EsameDellaBiancaLuca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        public int TicketId { get; set; }

        public bool? Utente { get; set; }

        public bool? Incaricato { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DataRichiesta { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DataChiusura { get; set; }

        public int? StatoRichiesta { get; set; }

        [StringLength(50)]
        public string TitoloRichiesta { get; set; }

        [StringLength(200)]
        public string DescrizioneRichiesta { get; set; }

        [StringLength(200)]
        public string DescrizioneRisposta { get; set; }

        public int? AnagraficaId { get; set; }

        public virtual Anagrafica Anagrafica { get; set; }
    }
}
