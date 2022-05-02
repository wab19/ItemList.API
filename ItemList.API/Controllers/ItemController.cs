using ItemList.API.EC;
using Library.CIS4930.Standard.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ItemList.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController
    {
        private readonly ILogger<ItemController> _logger;

        public ItemController(ILogger<ItemController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public IEnumerable<ItemDTO> Get()
        {
            List<ItemDTO> results = new List<ItemDTO>();
            results.AddRange(new TaskEC().Get().ToList());
            results.AddRange(new AppointmentEC().Get());
            return results;
        }
}
