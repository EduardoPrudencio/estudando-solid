using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PadroesDeProjeto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FunctionApiController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult Index(string id)
        {
            return Ok();
        }
    }
}