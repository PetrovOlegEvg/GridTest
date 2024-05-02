using GridTest.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace GridTest.Server.Controllers
{
    [ApiController]
    [Route("api")]
    public class DataController : ControllerBase
    {
        private readonly ILogger<DataController> _logger;
        private readonly Service _service;

        public DataController(ILogger<DataController> logger)
        {
            _logger = logger;
            _service = new Service();
        }

        [HttpGet("/{rowCount}")]
        public IActionResult Get(int rowCount)
        {
            return Ok(_service.GetTestGrid(rowCount));
        }
    }
}
