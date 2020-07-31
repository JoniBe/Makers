using Business.RestModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IEditorialServices
    {
        public IEnumerable<EditorialViewModel> GetEditoriales();
    }
}
