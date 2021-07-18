using Microsoft.Extensions.DependencyInjection;

namespace Cli
{
  public class DependencyInjectionHelper
  {
    public ServiceProvider SetupServiceProvider()
    {
      //setup Dependency Injection
      var serviceProvider = new ServiceCollection()
          // .AddSingleton<IFooService, FooService>()
          .BuildServiceProvider();
      return serviceProvider;
    }
  }
}