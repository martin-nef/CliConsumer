using System;

namespace Cli
{
  class Program
  {
    static void Main(string[] args)
    {
      var serviceProvider = new DependencyInjectionHelper().SetupServiceProvider();

      Console.WriteLine("Hello World!");
    }
  }
}
