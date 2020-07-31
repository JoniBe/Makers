using Business.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Database
{
    public class MakersContext : DbContext
    {
        public MakersContext(DbContextOptions<MakersContext> options) : base(options) { }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
    }
}
