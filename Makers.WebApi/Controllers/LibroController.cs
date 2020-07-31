using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.RestModel;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Makers.WebApi.Controllers
{
    [Route("api/libro")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly ILibrosServices _libroServices;

        public LibroController(ILibrosServices libroServices)
        {
            _libroServices = libroServices;
        }

        [Route("all")]
        [HttpGet]
        public IActionResult GetLibros()
        {
            return Ok(_libroServices.GetLibros());
        }

        [Route("update")]
        [HttpPut]
        public IActionResult EditLibro([FromForm] LibroViewModel libro)
        {
            _libroServices.EditLibro(libro);
            return Ok();
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public IActionResult DeleteLibro(int id)
        {
            _libroServices.RemoveLibro(id);
            return Ok();
        }

        [Route("create")]
        [HttpPost]
        public IActionResult AddLibro([FromForm] LibroViewModel libro)
        {
            _libroServices.AddLibro(libro);
            return Ok();
        }
    }
}
