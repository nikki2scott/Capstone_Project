namespace Capstone_Project.Models
{
    public class MediaItem
    {
        private int _id;
        private string _title = string.Empty;

        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }

        public virtual string GetSummary()
        {
            return $"Title: {Title}";
        }
    }
}
