using Capstone_Project.Interfaces;

namespace Capstone_Project.Models
{
    public class Book : MediaItem, ILoanable
    {
        private string _author = string.Empty;
        private string _genre = string.Empty;
        private bool _isAvailable = true;

        public string Author { get => _author; set => _author = value; }
        public string Genre { get => _genre; set => _genre = value; }
        public bool IsAvailable { get => _isAvailable; set => _isAvailable = value; }

        public override string GetSummary()
        {
            return $"{base.GetSummary()}, Author: {Author}, Genre: {Genre}, Available: {IsAvailable}";
        }
        public void CheckOut()
        {
            if (!IsAvailable) throw new InvalidOperationException("Book is already loaned.");
            IsAvailable = false;
        }

        public void ReturnItem()
        {
            IsAvailable = true;
        }
    }
}

