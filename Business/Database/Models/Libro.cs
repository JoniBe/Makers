using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Database.Models
{
    [DataContract]
    [Table("Libro")]
    public partial class Libro
    {
        public Libro() { }

        [Key]
        public int IdLibro { get; set; }
        [Required]
        [DataMember]
        [Column("Titulo")]
        public string Titulo { get; set; }
        [Required]
        [DataMember]
        [ForeignKey("Editorial")]
        [Column("IdEditorial")]
        public int IdEditorial { get; set; }
        [Required]
        [DataMember]
        [Column("Fecha")]
        public DateTime Fecha { get; set; }
        [Required]
        [DataMember]
        [Column("Costo")]
        public decimal Costo { get; set; }
        [Required]
        [DataMember]
        [Column("PrecioSugerido")]
        public decimal PrecioSugerido { get; set; }
        [Required]
        [DataMember]
        [Column("Autor")]
        public string Autor { get; set; }

        public virtual Editorial Editorial { get; set; }
    }
}
