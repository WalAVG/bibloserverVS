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
    public class InsertingController : ControllerBase
    {

        private readonly InsertingService _insertingService;
        public InsertingController(InsertingService insertingService)
        {
            _insertingService = insertingService;
        }


        // GET api/
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                var result = _insertingService.Get();
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
                var result = _insertingService.Find(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST api/values
        public ActionResult<string> Post([FromBody] InsertingDTO insertingDTO)
        {
            var result = _insertingService.Post(insertingDTO);
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
            var result = _insertingService.Find(id);
            var x = _insertingService.Delete(result);

        }
    }
}
