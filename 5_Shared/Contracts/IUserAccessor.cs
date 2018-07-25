using System.Threading.Tasks;
using Xpanxion.DataContracts;

namespace Xpanxion.Contracts
{
   public interface IUserAccessor :IDataAccess<User>
    {
        Task<User> GetUserByEmailAddress(string emailAddress);
    }
}
