using Microsoft.AspNetCore.Mvc;
using Publicaciones.Application.Contract;
using Publicaciones.Application.Dtos.Authors;
using Publicaciones.Application.Service;
using Publicaciones.Domain.Entities;
using Publicaciones.Domain.Repository;
using Publicaciones.Infraestructure.Interface;
using System;
using System.Numerics;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Publicaciones.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorsService authorsService;


        public AuthorsController(IAuthorsService authorsService) 
        {
            this.authorsService = authorsService;
        }


        // GET: api/<AuthorsController>
        [HttpGet]
        public IActionResult Get()
        {
            var authors = this.authorsService.Get();
            return Ok(authors);
        }

        // GET api/<AuthorsController>/5
        [HttpGet("{au_id}")]
        public IActionResult Get(string au_id)
        {
            var aut = this.authorsService.GetByau_id(au_id);
            return Ok(aut);
        }

        // POST api/<AuthorsController>
        [HttpPost("Save")]
        public IActionResult Post([FromBody] AuthorsAddDto authorsAdd)
        {
            var result = this.authorsService.Save(authorsAdd);

            return Ok(result);
        }



        // PUT api/<AuthorsController>/5
        [HttpPut("Update")]
        public IActionResult Put([FromBody] AuthorsUpdateDto authorsUpdate)

        {
            var result = this.authorsService.Update(authorsUpdate);

            return Ok(result);

        }

        // DELETE api/<AuthorsController>/5
        [HttpDelete("Remove")]
        public IActionResult Delete([FromBody] AuthorsRemoveDto authorsRemove)
        {
            var result = this.authorsService.Remove(authorsRemove);

            return Ok(result);
        }
    }
}
