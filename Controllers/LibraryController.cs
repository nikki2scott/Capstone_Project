using Microsoft.AspNetCore.Mvc;
// Library
namespace Capstone_Project.Controllers
{
    [ApiController]
    [Route("")]
    public class LibraryController : ControllerBase
    {
        // ===== 📚 Books =====

        [HttpGet("books")]
        public IActionResult GetAllBooks()
        {
            // Stub: Return placeholder book list
            return Ok(new[] { "Book 1", "Book 2" });
        }

        [HttpGet("books/{id}")]
        public IActionResult GetBookById(int id)
        {
            // Stub: Return placeholder book
            return Ok($"Book with ID {id}");
        }

        [HttpPost("books")]
        public IActionResult AddBook()
        {
            // Stub: Return placeholder message
            return Created("", "Book added");
        }

        [HttpPut("books/{id}")]
        public IActionResult UpdateBook(int id)
        {
            // Stub: Return placeholder update message
            return Ok($"Book {id} updated");
        }

        [HttpDelete("books/{id}")]
        public IActionResult DeleteBook(int id)
        {
            // Stub: Return placeholder delete message
            return Ok($"Book {id} deleted");
        }

        // ===== 👤 Users =====

        [HttpGet("users")]
        public IActionResult GetAllUsers()
        {
            // Stub: Return placeholder user list
            return Ok(new[] { "User 1", "User 2" });
        }

        [HttpPost("users")]
        public IActionResult AddUser()
        {
            // Stub: Return placeholder user creation
            return Created("", "User added");
        }

        // ===== 🔁 Loans =====

        [HttpGet("loans")]
        public IActionResult GetAllLoans()
        {
            // Stub: Return placeholder loan list
            return Ok(new[] { "Loan 1", "Loan 2" });
        }

        [HttpPost("loans")]
        public IActionResult CheckoutBook()
        {
            // Stub: Return placeholder loan
            return Created("", "Book loaned out");
        }

        [HttpPost("returns")]
        public IActionResult ReturnBook()
        {
            // Stub: Return placeholder return confirmation
            return Ok("Book returned");
        }
    }
}
