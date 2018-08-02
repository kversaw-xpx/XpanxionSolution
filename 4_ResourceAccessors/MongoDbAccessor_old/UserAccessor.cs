using MongoDB.Driver.Linq;
using System.Linq;
using Xpanxion.DataContracts;
using Xpanxion.Contracts;
using System.Threading.Tasks;
using System;

namespace Xpanxion.DatabaseAccessor
{
    public class UserAccessor : DataAccess<User>, IUserAccessor
    {

        public async Task<User> GetUserByEmailAddress(string emailAddress)
        {

            var data = await GetData();
            
            return await Task.Run(()=>data.Where(x=>x.Email==emailAddress).FirstOrDefault());

            //below is an example of try and catch for async code
            //Task T2 = Task.Factory.StartNew(() => { return string.Empty; });

            //try
            //{
            //    T2.Wait();
            //}
            //catch(AggregateException ae)
            //{
            //    ae.Flatten();
            //    foreach (Exception e in ae.InnerExceptions)
            //        Console.WriteLine(e.Message);
            //}     

        }
    }
}


