using Dummy.AspNetCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dummy.UnitTests;

[TestClass]
public sealed class Test1
{
  [TestMethod]
  public void TestMethod1()
  {
    var authScheme = new AuthenticationScheme("Name", "DisplayName", typeof(IAuthenticationHandler));

    var dummy = new Class1();
    dummy.DummyMethod(authScheme);
  }
}
