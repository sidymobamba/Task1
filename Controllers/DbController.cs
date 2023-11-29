using Microsoft.AspNetCore.Mvc;
using Task1.Models;
using Task1.Services;

namespace Task1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DbController : ControllerBase
    {
        private readonly DbService _dbService;

        public DbController(DbService dbService)
        {
            _dbService = dbService;
        }

        [HttpPost]
        public IActionResult PostJson([FromBody] JsonClass jsonClass)
        {
            try
            {
                _dbService.WriteToDatabase(jsonClass);
                return Ok("JSON successfully written to the database.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}
