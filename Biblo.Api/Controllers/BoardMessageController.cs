﻿using System;
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
    public class BoardMessageController : ControllerBase
    {

        private readonly BoardMessageService _boardMessageService;
        public BoardMessageController(BoardMessageService boardMessageService)
        {
            _boardMessageService = boardMessageService;
        }

        // GET api/boardmessage
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                var result = _boardMessageService.Get();
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
