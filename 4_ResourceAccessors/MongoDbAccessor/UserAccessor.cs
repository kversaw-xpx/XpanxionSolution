using MongoDB.Driver.Linq;
using System.Linq;
using Xpanxion.DataContracts;
using Xpanxion.Contracts;

namespace DatabaseAccessor
{
   public class UserAccessor : DataAccess<User>, IUserAccessor
    {       
       
        public User GetUserByEmailAddress(string emailAddress)
        {
            User returnUser;

            returnUser = GetData().Where(x=>x.Email == emailAddress).FirstOrDefault();          

            return returnUser;

        }
    }
}
