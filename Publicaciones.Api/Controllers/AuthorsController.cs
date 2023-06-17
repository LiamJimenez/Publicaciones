using Microsoft.AspNetCore.Mvc;
using Publicaciones.Application.Dtos.Authors;
using Publicaciones.Domain.Entities;
using Publicaciones.Infraestructure.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Publicaciones.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorsRepository authorsRepository;

        public AuthorsController(IAuthorsRepository authorsRepository) 
        {
            this.authorsRepository = authorsRepository;
        }


        // GET: api/<AuthorsController>
        [HttpGet]
        public IActionResult Get()
        {
            var authors = this.authorsRepository.GetEntities();
            return Ok(authors);
        }

        // GET api/<AuthorsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var aut = this.authorsRepository.GetAuthorsByau_id(id);
            return Ok(aut);
        }

        // POST api/<AuthorsController>
        [HttpPost("Save")]
        public IActionResult Post([FromBody] AuthorsAddDto authorsAdd)
        {

            this.authorsRepository.Add(new Authors()
            {
                city = authorsAdd.city,
                address = authorsAdd.address,
                modifydate = authorsAdd.ChangeDate,
                usermod = authorsAdd.ChangeUser,
                au_fname = authorsAdd.au_fname,
                au_lname = authorsAdd.au_lname,
                creationdate = authorsAdd.ChangeDate,
                creationuser = authorsAdd.ChangeUser,
            });

            return Ok();
        }



        // PUT api/<AuthorsController>/5
        [HttpPut("Update")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AuthorsController>/5
        [HttpDelete("Remove")]
        public void Delete(int id)
        {
        }
    }
}
