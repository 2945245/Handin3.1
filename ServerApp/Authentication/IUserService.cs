namespace ServerApp.Authentication
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
        void NewUser(User newUser); 
    }
}