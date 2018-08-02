using System.Linq;
using Xpanxion.Contracts;
using Xpanxion.DataContracts;

namespace Xpanxion.Engines
{
    public class UserEngine : IUserEngine
    {
        public bool DoesUserHaveCredential(User user, Credential credential)
        {
            bool returnValue = false;

            var credQuery = user.Credentials.Where(x => x.Id == credential.Id);

            returnValue = credQuery.Count() > 0 ? true : false;
            return returnValue;
        }
    }  
}
