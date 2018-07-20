using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xpanxion.Contracts;
using Xpanxion.DataContracts;
using Xpanxion.IoC;

namespace MongoDbAccessor_Test
{
    [TestClass]
    public class UserAccessor_Test
    {
        [TestMethod]
        public void AddData_AddingNewUser_UserWillBeAdded()
        {
            IUserAccessor userAccessor = DependencyInjection.ResolveDependency<IUserAccessor>();
            userAccessor.AddOneItem(new User {FirstName="Test",LastName="McTesterson" });

        }   

    }
}
