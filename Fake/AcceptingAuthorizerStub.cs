using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake
{
    public class AcceptingAuthorizerStub:IAuthorizer
    {
        public bool authorize(string username, string password)
        {
            return true;
        }
    }
}
