using Xpanxion.DataContracts;

namespace Xpanxion.Contracts
{
   public interface IUserAccessor :IDataAccess<User>
    {
        User GetUserByEmailAddress(string emailAddress);
    }
}
