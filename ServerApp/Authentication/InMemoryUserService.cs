using System;
using System.Collections.Generic;
using System.Linq;
using ServerApp.Model;

namespace ServerApp.Authentication
{
    public class InMemoryUserService: IUserService
    {
        private IList<User> users;
        private RegisteredUsers rUsers;

        public InMemoryUserService()
        {
            if (rUsers == null)
            {
                rUsers = new RegisteredUsers();
            }

            users = rUsers.RUsers;
        }

        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            
            if (first == null)
            {
                throw new Exception("User Not Found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }
            return first;
        }

        public void NewUser(User newUser)
        {
            users.Add(newUser);
            users = rUsers.RUsers;
            rUsers.SaveChanges();
            
           
        }
    }
}