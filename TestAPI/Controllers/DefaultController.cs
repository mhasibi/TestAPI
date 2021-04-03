using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class DefaultController : ControllerBase
    {
        public GetResults Get()
        {
            return Ok("This is working !")
        }
    }
}
