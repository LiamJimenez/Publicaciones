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
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesService employeesService;


        public AuthorsController(IEmployeesService employeesService)
        {
            this.employeesService = employeesService;
        }



        // GET: api/<AuthorsController>
        [HttpGet]
        public IActionResult Get()
        {
            var employees = this.employeesService.Get();
            return Ok(employees);
        }


        // GET api/<AuthorsController>/5
        [HttpGet("{au_id}")]
        public IActionResult Get(string emp_id)
        {
            var emp = this.employeesService.GetByemp_id(emp_id);
            return Ok(emp);
        }


        // POST api/<AuthorsController>
        [HttpPost("Save")]
        public IActionResult Post([FromBody] EmployeesAddDto employeesAdd)
        {
            var result = this.employeesService.Save(employeesAdd);

            return Ok(result);
        }


        // PUT api/<AuthorsController>/5
        [HttpPut("Update")]
        public IActionResult Put([FromBody] EmployeesUpdateDto employeesUpdate)

        {
            var result = this.employeesService.Update(employeesUpdate);

            return Ok(result);

        }


        // DELETE api/<AuthorsController>/5
        [HttpDelete("Remove")]
        public IActionResult Delete([FromBody] EmployeesRemoveDto employeesRemove)
        {
            var result = this.employeesService.Remove(employeesRemove);

            return Ok(result);
        }
    }
}