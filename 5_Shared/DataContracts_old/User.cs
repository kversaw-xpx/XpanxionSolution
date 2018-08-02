using System.Collections.Generic;

namespace Xpanxion.DataContracts
{
    public class User : BaseClass
    {             
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; } = false;

        public ICollection<Credential> Credentials { get; set; }
    }
}
