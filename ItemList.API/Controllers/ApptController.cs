using ItemList.API.Database;
using ItemList.API.EC;
using Library.CIS4930.Standard.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ItemList.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentController
    {
        private readonly ILogger<AppointmentController> _logger;

        public AppointmentController(ILogger<AppointmentController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public IEnumerable<AppointmentDTO> Get()
        {
            return new AppointmentEC().Get();
        }
    }
}
