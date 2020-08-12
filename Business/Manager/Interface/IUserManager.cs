namespace Business.Manager
{
    public interface IUserManager
    {
        string GetGuid();
        string GetUserName(int id);
    }
}