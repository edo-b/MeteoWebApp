using MeteoWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoWebApp.Infrastructure.User
{
    public class UserQueries : IUserQueries
    {
        public bool ValidateUser(string username, string password)
        {
            using(var db = new DatabaseModelContainer())
            {
                var dbUser = db.Users.SingleOrDefault(x => x.Username == username && x.Password == password);

                return dbUser != null;
            }
        }

        public string GetUserSalt(string username)
        {
            using (var db = new DatabaseModelContainer())
            {
                var dbUser = db.Users.SingleOrDefault(x => x.Username == username);

                if(dbUser != null)
                {
                    return dbUser.Salt;
                }
                
                return null;
            }
        }
    }
}
