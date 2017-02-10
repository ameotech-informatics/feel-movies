using MovieFeeler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.Manager.Interfaces
{
   public interface IUserManager
    {
       void Register(User user);

       bool Login(string username, string password);

    }
}
