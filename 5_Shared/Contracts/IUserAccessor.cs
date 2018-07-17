using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpanxion.DataContracts;

namespace Xpanxion.Contracts
{
   public interface IUserAccessor :IDataAccess<User>
    {
        User GetUserByEmailAddress(string emailAddress);
    }
}
