using Microsoft.Extensions.DependencyInjection;

namespace Cli
{
    public class DependencyInjectionHelper
    {
        public ServiceProvider SetupServiceProvider()
        {
            var serviceProvider = new ServiceCollection()
                // .AddTransient<TInterface, TImplementation>()
                .BuildServiceProvider();
            return serviceProvider;
        }
    }
}