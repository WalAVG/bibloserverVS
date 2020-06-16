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
    public class PrivateMessageController : ControllerBase
    {

        private readonly PrivateMessageService _privateMessageService;
        public PrivateMessageController(PrivateMessageService privateMessageService)
        {
            _privateMessageService = privateMessageService;
        }


        // GET api/
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                var result = _privateMessageService.Get();
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
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Post([FromBody] PrivateMessageDTO privateMessageDTO)
        {
            var result = _privateMessageService.Post(privateMessageDTO);
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
