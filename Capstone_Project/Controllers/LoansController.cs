using Microsoft.AspNetCore.Mvc;
using Capstone_Project.Models;
// Loans
namespace Capstone_Project.Controllers
{
    [ApiController]
    [Route("")]
    public class LoansController : ControllerBase
    {
        private static List<Book> books = BooksControllerBooks(); // Hacky cross-access for demo
        private static List<User> users = UsersControllerUsers();
        private static List<Loan> loans = new();

        [HttpGet("loans")]
        public IActionResult GetAllLoans() => Ok(loans);

        [HttpPost("loans")]
        public IActionResult CheckoutBook([FromBody] Loan newLoan)
        {
            var book = books.FirstOrDefault(b => b.Id == newLoan.BookId);
            var user = users.FirstOrDefault(u => u.Id == newLoan.UserId);

            if (book == null || user == null) return BadRequest("Invalid Book or User ID.");
            if (!book.IsAvailable) return BadRequest("Book is already loaned out.");

            newLoan.Id = loans.Count + 1;
            newLoan.LoanDate = DateTime.Now;
            newLoan.ReturnDate = null;

            book.IsAvailable = false;
            loans.Add(newLoan);

            return CreatedAtAction(nameof(GetAllLoans), new { id = newLoan.Id }, newLoan);
        }

        [HttpPost("returns")]
        public IActionResult ReturnBook([FromBody] int loanId)
        {
            var loan = loans.FirstOrDefault(l => l.Id == loanId);
            if (loan == null || loan.ReturnDate != null)
                return BadRequest("Invalid or already returned loan.");

            var book = books.FirstOrDefault(b => b.Id == loan.BookId);
            if (book != null)
                book.IsAvailable = true;

            loan.ReturnDate = DateTime.Now;

            return Ok("Book returned successfully.");
        }

        // Simulate shared access (TEMP FIX for demo only)
        private static List<Book> BooksControllerBooks() =>
            typeof(BooksController)
            .GetField("books", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)!
            .GetValue(null) as List<Book> ?? new();

        private static List<User> UsersControllerUsers() =>
            typeof(UsersController)
            .GetField("users", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)!
            .GetValue(null) as List<User> ?? new();
    }
}
