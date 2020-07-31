using Business.Database;
using Business.Database.Models;
using Business.RestModel;
using Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;

namespace Services
{
    public class LibroServices : ILibrosServices
    {
        private readonly MakersContext _dbContext;
        private readonly IEditorialServices _editorialServices;

        public LibroServices(MakersContext dbContext, IEditorialServices editorialServices)
        {
            _dbContext = dbContext;
            _editorialServices = editorialServices;
        }

        public void AddLibro(LibroViewModel libro)
        {
            var _libro = new Libro
            {
                Titulo = libro.titulo,
                Autor = libro.autor,
                Costo = libro.costo,
                IdEditorial = libro.idEditorial,
                Fecha = libro.fecha,
                PrecioSugerido = libro.precioSugerido
            };

            _dbContext.Libros.Add(_libro);
            _dbContext.SaveChanges();
        }

        public void EditLibro(LibroViewModel libro)
        {
            var _libro = _dbContext.Libros.FirstOrDefault(x => x.IdLibro == libro.id);

            if (_libro is null)
            {
                throw new Exception("Libro not found.");
            }
            else
            {
                _libro.Autor = libro.autor;
                _libro.Costo = libro.costo;
                _libro.IdEditorial = libro.idEditorial;
                _libro.PrecioSugerido = libro.precioSugerido;
                _libro.Titulo = libro.titulo;
                _libro.Fecha = libro.fecha;

                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<LibroViewModel> GetLibros()
        {
            var libros = _dbContext.Libros
                .Include("Editorial")
                .Select(x => new LibroViewModel(x))
                .ToList();

            return libros;
        }

        public void RemoveLibro(int id)
        {
            var libro = _dbContext.Libros.FirstOrDefault(x => x.IdLibro == id);

            if (libro is null)
            {
                throw new Exception("Libro not found.");
            }
            else
            {
                _dbContext.Libros.Remove(libro);
                _dbContext.SaveChanges();
            }
        }
    }
}
