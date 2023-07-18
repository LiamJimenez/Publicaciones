using Microsoft.AspNetCore.Mvc;
using Publicaciones.Application.Contract;
using Publicaciones.Application.Dtos.titleauthor;



namespace Publicaciones.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ITitleAuthorService tileAuthortService;

        public WeatherForecastController(ITitleAuthorService tileAuthortService)
        {
            this.tileAuthortService = tileAuthortService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var title = this.tileAuthortService.Get();
            return Ok(title);
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var titleAth = this.tileAuthortService.GetById(id);
            return Ok(titleAth);
        }


        [HttpPost("Save")]
        public IActionResult Post([FromBody] TitleAuthorAddDto titleAuthorAdd)
        {

            var result = this.tileAuthortService.Save(titleAuthorAdd);

            return Ok(result);
        }


        [HttpPost("Update")]
        public IActionResult Put([FromBody] titleAuthorUpdateDto titleAuthortUpdate)
        {


            var result = this.tileAuthortService.Update(titleAuthortUpdate);

            return Ok(result);
        }


        [HttpPost("Remove")]
        public IActionResult Delete([FromBody] titleAuthorRemoveDto titleAuthortRemoveDto)
        {

            var result = this.tileAuthortService.Remove(titleAuthortRemoveDto);
            return Ok(result);
        }
    }
}