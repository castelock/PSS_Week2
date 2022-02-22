using Fake;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FakeTests
{
    [TestClass]
    public class System
    {
        IAuthorizer authorizer;
        public System(IAuthorizer authorizer)
        {
            this.authorizer = authorizer;
        }

        public int loginCount()
        {
            // Retorna el número de usuarios logueados
            // o autentificados basado en el Authorizer
            return 0;
        }

        [TestMethod]
        public void newlyCreatedSystem_hasNoLoggedInUsers()
        {
            System system = new System(new DummyAuthorizer());
            Assert.AreEqual(system.loginCount(), 0);
        }
    }
}