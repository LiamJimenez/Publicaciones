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
    public class JobsController : ControllerBase
    {
        private readonly IJobsService jobsService;


        public AuthorsController(IJobsService jobsService)
        {
            this.jobsService = jobsService;
        }



        // GET: api/<AuthorsController>
        [HttpGet]
        public IActionResult Get()
        {
            var jobs = this.jobsService.Get();
            return Ok(jobs);
        }


        // GET api/<AuthorsController>/5
        [HttpGet("{au_id}")]
        public IActionResult Get(string job_id)
        {
            var job = this.jobsService.GetByjob_id(job_id);
            return Ok(job);
        }


        // POST api/<AuthorsController>
        [HttpPost("Save")]
        public IActionResult Post([FromBody] JobsAddDto jobsAdd)
        {
            var result = this.jobsService.Save(jobsAdd);

            return Ok(result);
        }


        // PUT api/<AuthorsController>/5
        [HttpPut("Update")]
        public IActionResult Put([FromBody] JobsUpdateDto jobsUpdate)

        {
            var result = this.jobsService.Update(jobsUpdate);

            return Ok(result);

        }


        // DELETE api/<AuthorsController>/5
        [HttpDelete("Remove")]
        public IActionResult Delete([FromBody] JobsRemoveDto jobsRemove)
        {
            var result = this.jobsService.Remove(jobsRemove);

            return Ok(result);
        }
    }
}