using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Database.Models
{
    [DataContract]
    [Table("Editorial")]
    public partial class Editorial
    {
        public Editorial() { }

        [Key]
        public int IdEditorial { get; set; }
        [Required]
        [DataMember]
        [Column("Nombre")]
        public string Nombre { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }
}
