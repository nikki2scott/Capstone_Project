using Microsoft.AspNetCore.Mvc;
using Capstone_Project.Models;
// Users
namespace Capstone_Project.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersController : ControllerBase
    {
        private static List<User> users = new()
        {
            new User { Id = 1, Name = "Alice", Email = "alice@example.com" },
            new User { Id = 2, Name = "Bob", Email = "bob@example.com" }
        };

        [HttpGet]
        public IActionResult GetAllUsers() => Ok(users);

        [HttpPost]
        public IActionResult AddUser([FromBody] User newUser)
        {
            newUser.Id = users.Count + 1;
            users.Add(newUser);
            return CreatedAtAction(nameof(GetAllUsers), new { id = newUser.Id }, newUser);
        }
    }
}
