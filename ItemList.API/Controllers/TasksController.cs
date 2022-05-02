using ItemList.API.Database;
using ItemList.API.EC;
using Library.CIS4930.Standard.DTO;
using CIS4930.models;
using CIS4930.services;
using Microsoft.AspNetCore.Mvc;

namespace ItemList.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ILogger<TasksController> _logger;

        public TasksController(ILogger<TasksController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public IEnumerable<ItemDTO> Get()
        {
            return new TaskEC().Get();
        }

        [HttpPost("AddOrUpdate")]
        public TaskDTO AddOrUpdate([FromBody] TaskDTO todo)
        {

            return new TaskEC().AddOrUpdate(todo);
        }

        [HttpPost("Delete")]
        public TaskDTO Delete([FromBody] DeleteItemDTO deleteItemDTO)
        {
            return new TaskEC().Delete(deleteItemDTO.IdToDelete);
        }
    }
}
