using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Config.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly IConfiguration _configuration; 

        private readonly ILogger<ConfigController> _logger; 
        public ConfigController(IConfiguration configuration, ILogger<ConfigController> logger)
        {
            _configuration=configuration;
            _logger=logger;
        }


        [HttpGet]
        [Route("config")]
        public void get (int id)
        {
            if (id==1)
            {
                _logger.LogInformation(2,"this is information");
   
            }
            else if(id==1)
            {
                _logger.LogDebug(1,"this is from debug");
            }
            else if(id==3)
            {
                _logger.LogWarning(3,"this is warning");
            }
            else
            {
                _logger.LogError(4,"this is error");

            }

            return;
        }
    }
}
