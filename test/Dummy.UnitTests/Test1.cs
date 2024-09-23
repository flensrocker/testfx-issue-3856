using Dummy.AspNetCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dummy.UnitTests;

[TestClass]
public sealed class Test1
{
  [TestMethod]
  public void TestMethod1()
  {
    var authScheme = new Microsoft.AspNetCore.Authentication.AuthenticationScheme("Name", "DisplayName", typeof(string));

    var dummy = new Class1();
    dummy.DummyMethod(authScheme);
  }
}
