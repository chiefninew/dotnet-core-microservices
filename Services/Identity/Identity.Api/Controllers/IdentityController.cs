using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IdentityController : ControllerBase
    {
        private readonly ILogger<IdentityController> _logger;

        public IdentityController(ILogger<IdentityController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetIdentityController")]
        public string Get()
        {
            return "This is Identity Microservice";
        }
    }
}
