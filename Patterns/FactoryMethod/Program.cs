using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var developmentManager = new DevelopmentManager();
            Console.WriteLine(developmentManager.TakeInterview());

            var marketingManager = new MarketingManager();
            Console.WriteLine(marketingManager.TakeInterview());

            Console.ReadKey();
        }
    }
}
