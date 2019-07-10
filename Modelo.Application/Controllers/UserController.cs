using Microsoft.AspNetCore.Mvc;
using Modelo.Domain.Entities;
using Modelo.Service.Services;
using Modelo.Service.Validators;
using System;

namespace Modelo.Application.Controllers
{
    [Produces("application/json")]
    [Route("[controller]/[action]")]
    public class UserController : Controller
    {
        private BaseService<User> service = new BaseService<User>();

        [HttpPost]
        public IActionResult Post([FromBody] User item)
        {
            try
            {
                service.Post<UserValidator>(item);

                return new ObjectResult(item.Id);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] User item)
        {
            try
            {
                service.Put<UserValidator>(item);

                return new ObjectResult(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                service.Delete(id);

                return new NoContentResult();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpGet]
        //public IList<T> Get()
        //{
        //    try
        //    {
        //        return new ObjectResult(service.Get());
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //    }
        //}

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            try
            {
                return new ObjectResult(service.Get(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}

