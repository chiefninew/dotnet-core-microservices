using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApplicationController : ControllerBase
    {
        private readonly ILogger<ApplicationController> _logger;

        public ApplicationController(ILogger<ApplicationController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetApplicationController")]
        public string Get()
        {
            return "This is Application Microservice";
        }
    }
}
