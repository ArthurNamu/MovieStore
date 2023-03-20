using CleanMovie.Domain.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application.Security
{
    public interface IUsersRepository
    {
        bool IsValidUser(User user);
    }
}
