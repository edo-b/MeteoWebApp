using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoWebApp.Infrastructure.User
{
    public interface IUserQueries
    {
        bool ValidateUser(string username, string password);
        string GetUserSalt(string username);
    }
}
