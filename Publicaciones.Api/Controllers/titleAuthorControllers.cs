using Microsoft.AspNetCore.Mvc;
using Publicaciones.Application.Contract;
using Publicaciones.Application.Dtos.titleauthor;
using Publicaciones.Application.Service;
using System;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Publicaciones.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class titleAuthorControllers : ControllerBase
    {
        private readonly ITitleAuthorService TillEauthorsService;


        public titleAuthorControllers(ITitleAuthorService TillEauthorsService)
        {
            this.TillEauthorsService = TillEauthorsService;
        }




        // GET: api/<TilteAuthorController>
        [HttpGet]
        public IActionResult Get()
        {
            var Titleauthor = this.TillEauthorsService.Get();
            return Ok(Titleauthor);
        }



        // GET api/<TilteAuthorController>/5
        [HttpGet("{au_id}")]
        public IActionResult Get(int au_id)
        {
            var aut = this.TillEauthorsService.GetByau_id(au_id);
            return Ok(aut);
        }



        // POST api/<TilteAuthorController>
        [HttpPost("Save")]
        public IActionResult Post([FromBody] TitleAuthorAddDto TitleauthorsAdd)
        {
            var result = this.TillEauthorsService.Save(TitleauthorsAdd);

            return Ok(result);
        }



        // PUT api/<TilteAuthorController>/5
        [HttpPut("Update")]
        public IActionResult Put([FromBody] titleAuthorUpdateDto TilleauthorsUpdate)

        {
            var result = this.TillEauthorsService.Update(TilleauthorsUpdate);

            return Ok(result);

        }



        // DELETE api/<TilteAuthorController>/5
        [HttpDelete("Remove")]
        public IActionResult Delete([FromBody] titleAuthorRemoveDto TileauthorsRemove)
        {
            var result = this.TillEauthorsService.Remove(TileauthorsRemove);

            return Ok(result);
        }
    }
}