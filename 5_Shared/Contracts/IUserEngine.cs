using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpanxion.DataContracts;
using Xpanxion.Contracts;
namespace Xpanxion.Contracts
{
    public interface IUserEngine
    {
        bool DoesUserHaveCredential(User user, Credential credential);
    }
}
