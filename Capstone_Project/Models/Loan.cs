namespace Capstone_Project.Models
{
    public class Loan
    {
        private int _id;
        private int _bookId;
        private int _userId;
        private DateTime _loanDate;
        private DateTime? _returnDate;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public int BookId
        {
            get => _bookId;
            set => _bookId = value;
        }

        public int UserId
        {
            get => _userId;
            set => _userId = value;
        }

        public DateTime LoanDate
        {
            get => _loanDate;
            set => _loanDate = value;
        }

        public DateTime? ReturnDate
        {
            get => _returnDate;
            private set => _returnDate = value;
        }

        public bool IsReturned => ReturnDate.HasValue;

        public void Return()
        {
            if (IsReturned)
            {
                throw new InvalidOperationException("This loan has already been returned.");
            }

            ReturnDate = DateTime.Now;
        }
    }
}
