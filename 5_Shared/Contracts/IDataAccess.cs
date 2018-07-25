using System.Collections.Generic;
using System.Threading.Tasks;

namespace Xpanxion.Contracts
{
    public interface IDataAccess<t> 
    {
         Task<IEnumerable<t>> GetData();
         void AddOneItem(t dataItem);       
    }
}
