using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpanxion.Contracts;
using Xpanxion.DataContracts;

namespace Xpanxion.UserManager
{
    public class UserManager : IUserManager
    {
        public User GetUserByEmail(string emailAddress)
        {
            throw new NotImplementedException();
        }

        public User UpdateUserCredentials(ICollection<Credential> credentails, User user)
        {
            throw new NotImplementedException();
        }

        public void AddNewUser(User user)
        {

        }
    }
}
