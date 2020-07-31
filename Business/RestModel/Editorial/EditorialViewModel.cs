using Business.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.RestModel
{
    public class EditorialViewModel
    {
        public EditorialViewModel () { }
        public EditorialViewModel (Editorial e) 
        {
            id = e.IdEditorial;
            nombre = e.Nombre;
        }
        public int id { get; set; }
        public string nombre { get; set; }
    }
}
