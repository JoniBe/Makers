using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Makers.WebApi.Controllers
{
    [Route("api/editorial")]
    [ApiController]
    public class EditorialController : ControllerBase
    {
        private readonly IEditorialServices _editorialServices;

        public EditorialController(IEditorialServices editorialServices)
        {
            _editorialServices = editorialServices;
        }

        [Route("all")]
        [HttpGet]
        public IActionResult GetEditoriales()
        {
            return Ok(_editorialServices.GetEditoriales());
        }
    }
}
