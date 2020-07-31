using Business.RestModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface ILibrosServices
    {
        void AddLibro(LibroViewModel libro);
        void RemoveLibro(int id);
        IEnumerable<LibroViewModel> GetLibros();
        void EditLibro(LibroViewModel libro);
    }
}
