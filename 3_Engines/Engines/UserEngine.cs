using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpanxion.Contracts;
using Xpanxion.DataContracts;

namespace Xpanxion.Engines
{
    public class UserEngine : IUserEngine
    {
        public bool DoesUserHaveCredential(User user, Credential credential)
        {
            bool returnValue = false;

            var credQuery = user.Credentials.Where(x => x.CredentialId == credential.CredentialId);

            returnValue = credQuery.Count() > 0 ? true : false;
            return returnValue;
        }
    }  
}
