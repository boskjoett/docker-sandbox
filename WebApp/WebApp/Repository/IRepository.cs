namespace WebApp.Repository
{
    public interface IRepository
    {
        int GetCounter();
        void IncrementCounter();

        string GetMessage();
        void SetMessage(string message);
    }
}
