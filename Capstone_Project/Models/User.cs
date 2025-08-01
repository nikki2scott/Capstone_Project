namespace Capstone_Project.Models
{
    public class User : Person
    {
        private string _email = string.Empty;

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public override string GetContactInfo()
        {
            return $"{base.GetContactInfo()}, Email: {Email}";
        }
    }
}
