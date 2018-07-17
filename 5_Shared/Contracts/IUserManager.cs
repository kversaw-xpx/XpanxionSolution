using System.Collections.Generic;
using Xpanxion.DataContracts;

namespace Xpanxion.Contracts
{
    public interface IUserManager
    {
        User GetUserByEmail(string emailAddress);
        User UpdateUserCredentials(ICollection<Credential> credentails, User user);
        void AddNewUser(User user);
    }
}
