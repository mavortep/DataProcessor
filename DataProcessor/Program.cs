using Microsoft.Extensions.DependencyInjection;
using DataProcessor.Contracts.Domain.Services;
using System;

namespace DataProcessor
{
    class Program
    {
        static void Main(string[] args)
        {

            IServiceCollection services = new ServiceCollection();

            Startup startup = new Startup();

            startup.ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();

            var messageHistoryService = serviceProvider.GetService<IMessageHistoryService>();

            messageHistoryService.Process();

            //TODO: write data to different sources

            Console.ReadKey();
        }
    }
}
