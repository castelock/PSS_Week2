using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake
{
    public class AcceptingAuthorizerSpy : IAuthorizer
    {
        public bool authorizeWasCalled = false;
        public bool authorize(string username, string password)
        {
            authorizeWasCalled = true;
            return true;
        }
    }
}
