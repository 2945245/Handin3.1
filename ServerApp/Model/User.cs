namespace ServerApp.Model
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int SecurityLevel { get; private set; }

        public User()
        {
            SecurityLevel= SetSecurityLevel();
        }

        private int SetSecurityLevel()
        {
            int securityLevel;
            if (Age >= 18)
            {
                securityLevel = 10;
            }
            else
            {
                securityLevel = 0;
            }

            return securityLevel;
        }
    }
}