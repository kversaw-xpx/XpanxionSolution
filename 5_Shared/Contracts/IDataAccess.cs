using System.Collections.Generic;

namespace Xpanxion.Contracts
{
    public interface IDataAccess<t> 
    {
         IEnumerable<t> GetData();
         void AddOneItem(t dataItem);       
    }
}
