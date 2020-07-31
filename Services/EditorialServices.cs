using Business.Database;
using Business.RestModel;
using Contracts;
using Business.RestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Services
{
    public class EditorialServices : IEditorialServices
    {
        private readonly MakersContext _dbContext;

        public EditorialServices(MakersContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<EditorialViewModel> GetEditoriales()
        {
            var retorno = _dbContext.Editoriales
                .Select(x => new EditorialViewModel(x))
                .ToList();

            return retorno;
        }
    }
}
