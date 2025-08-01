namespace Capstone_Project.Models
{
    public class Book
    {
        private int _id;
        private string _title = string.Empty;
        private string _author = string.Empty;
        private string _genre = string.Empty;
        private bool _isAvailable = true;

        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public string Author { get => _author; set => _author = value; }
        public string Genre { get => _genre; set => _genre = value; }
        public bool IsAvailable { get => _isAvailable; set => _isAvailable = value; }
    }
}
