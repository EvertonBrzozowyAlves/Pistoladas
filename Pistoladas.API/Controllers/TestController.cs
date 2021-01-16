using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Pistoladas.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[action]")]
        public string Test()
        {
            var rng = new Random();
            return rng.Next(-10, 10).ToString();
        }

        [HttpGet]
        [Route("[action]")]
        public string Log()
        {
            _logger.LogInformation("Simple test");
            return "ok";
        }
    }
}
