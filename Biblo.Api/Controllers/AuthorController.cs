using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblo.Api.BO;
using Biblo.Api.Dto.Get;
using Biblo.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Biblo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly AuthorService _authorService;
        public AuthorController (AuthorService authorService)
        {
            _authorService = authorService;
        }


        // GET api/author
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                var result = _authorService.Get();
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {
                var result = _authorService.Find(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Post([FromBody] AuthorDTO authorDTO)
        {
            var result = _authorService.Post(authorDTO);
            return Ok(result);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
