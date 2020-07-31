using Business.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.RestModel
{
    public class LibroViewModel
    {
        public LibroViewModel() { }
        public LibroViewModel(Libro l)
        {
            id = l.IdLibro;
            titulo = l.Titulo;
            idEditorial = l.IdEditorial;
            editorial = new EditorialViewModel(l.Editorial);
            fecha = l.Fecha;
            costo = l.Costo;
            precioSugerido = l.PrecioSugerido;
            autor = l.Autor;
        }

        public int id { get;set; }
        public string titulo { get; set; }
        public int idEditorial { get; set; }
        public virtual EditorialViewModel editorial { get; set; }
        public DateTime fecha { get; set; }
        public decimal costo { get; set; }
        public decimal precioSugerido { get; set; }
        public string autor { get; set; }
    }
}
