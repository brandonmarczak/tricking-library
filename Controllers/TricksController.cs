﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrickingLibrary.Api.Models;

namespace TrickingLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/tricks")]
    public class TricksController : ControllerBase
    {
        private readonly TrickyStore _store;

        public TricksController(TrickyStore store)
        {
            _store = store;
        }

        [HttpGet]
        public IActionResult All() => Ok(_store.All);

        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok(_store.All.FirstOrDefault(x => x.Id.Equals(id)));

        [HttpPost]
        public IActionResult Post([FromBody] Trick trick)
        {
            _store.Add(trick);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromBody] Trick trick)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
