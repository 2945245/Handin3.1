using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ServerApp.Model;

namespace ServerApp.Data
{
    public class RegisteredUser
    {
        public IList<User> RUsers { get; set; }

        private string usersFile = "users.json";

        public RegisteredUser()
        {
            
            if (!File.Exists(usersFile))
            {
                RUsers = File.Exists(usersFile) ? ReadData<DbLoggerCategory.Model.User>(usersFile) : new List<User>();

            }
            else
            {
                string content = File.ReadAllText(usersFile);
                RUsers = JsonSerializer.Deserialize<List<User>>(content);
            }
        }

        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(s))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
   
            }
        }

        public void SaveChanges()
        {
            string jsonUsers = JsonSerializer.Serialize(RUsers, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(usersFile, false))
            {
                outputFile.Write(jsonUsers);
            }
        }
    }
}