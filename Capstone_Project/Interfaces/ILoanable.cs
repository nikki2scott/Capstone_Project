namespace Capstone_Project.Interfaces
{
    public interface ILoanable
    {
        bool IsAvailable { get; set; }
        void CheckOut();
        void ReturnItem();
    }
}
