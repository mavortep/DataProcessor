using DataProcessor.Contracts.Domain.Manager;
using DataProcessor.Contracts.Domain.Services;
using DataProcessor.Contracts.Domain.Strategies;
using DataProcessor.Domain.Managers;
using DataProcessor.Domain.Models.Configuration;
using DataProcessor.Domain.Services;
using DataProcessor.Domain.Strategies;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataProcessor
{
    public class Startup
    {
        private readonly IConfigurationRoot Configuration;

        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();
            services.Configure<ApplicationConfiguration>(Configuration);
            services.AddTransient<IDataReaderStrategy, JsonDataReaderStrategy>();
            services.AddTransient<IMessageHistoryManager, MessageHistoryManager>();
            services.AddTransient<IMessageHistoryService, MessageHistoryService>();
            services.BuildServiceProvider();
        }
    }
}
