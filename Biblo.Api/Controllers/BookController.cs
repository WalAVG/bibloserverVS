using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblo.Api.BO;
using Biblo.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Biblo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookService _bookService;
        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        // Libri fittizzi
        Book[] books = new Book[]
        {
            new Book { title = "Scarso", author = null},
            new Book { title = "Il numero 2", author = null} 
        };

        // GET api/book
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                var result = _bookService.Get();
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET api/book/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return books[id].title;
        }

        // POST api/book
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
