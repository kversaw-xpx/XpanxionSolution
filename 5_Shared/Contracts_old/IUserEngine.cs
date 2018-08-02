using Xpanxion.DataContracts;

namespace Xpanxion.Contracts
{
    public interface IUserEngine
    {
        bool DoesUserHaveCredential(User user, Credential credential);
    }
}
