namespace Dummy.AspNetCore;

public class Class1
{
  public void DummyMethod(Microsoft.AspNetCore.Authentication.AuthenticationScheme authScheme)
  {
    if (string.IsNullOrEmpty(authScheme.Name))
      throw new Exception("Dummy");
  }
}
