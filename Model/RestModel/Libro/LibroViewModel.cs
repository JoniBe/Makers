using System;
using System.Collections.Generic;
using System.Text;

namespace Model.RestModel
{
    public class LibroViewModel
    {
        public string titulo { get; set; }
        public int idEditorial { get; set; }
        public virtual EditorialViewModel editorial { get; set; }
        public DateTime fecha { get; set; }
        public decimal costo { get; set; }
        public decimal precioSugerido { get; set; }
        public string autor { get; set; }
    }
}
