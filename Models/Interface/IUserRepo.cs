using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frosh.Models.Interface
{
    public interface IUserRepo
    {
        bool SignUp(string name, string email, string password, string accType);
        object SignIn(string email, string password);
        String ReturnUsersName(string email);



    }
}
