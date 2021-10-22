using Eureka.Application.DTO;
using Eureka.Application.Interface;
using Eureka.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Eureka.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CrudController : ControllerBase
    {
        private readonly ICrudService _crudService;
        public CrudController(ICrudService crudService)
        {
            _crudService = crudService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_crudService.GetAll());
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(Guid Id)
        {
            return Ok(_crudService.GetById(Id));
        }

        [HttpPost]
        public IActionResult Add([FromBody] CrudDto entity)
        {
            _crudService.Insert(entity);
            return Ok(entity);
        }

        [HttpPut("{Id}")]
        public IActionResult Update(Guid Id, [FromBody] CrudDto entity)
        {
            _crudService.Update(Id, entity);
            return Ok(entity);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(Guid Id)
        {
            _crudService.Delete(Id);
            return Ok();
        }
    }
}
