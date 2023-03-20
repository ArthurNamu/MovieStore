using CleanMovie.Application.Security;
using CleanMovie.Domain.Security;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure.Security
{
    public class UsersRepository : IUsersRepository
    {
        Dictionary<string, string> UsersRecords = new Dictionary<string, string>
        {
            { "admin","admin"},
            { "password","password"}
        };

       public bool IsValidUser(User user)
        {
            //Go to the database and check if user is valid
            if(!UsersRecords.Any(x=>x.Key == user.Name && x.Value == user.Password))
            {
                return false;
            }
            return true;
        }
    }
}
