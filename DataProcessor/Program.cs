using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using DataProcessor.Contracts.Domain.Manager;
using DataProcessor.Contracts.Domain.Services;
using DataProcessor.Contracts.Domain.Strategies;
using DataProcessor.Domain.Managers;
using DataProcessor.Domain.Services;
using DataProcessor.Domain.Strategies;
using System;

namespace DataProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddTransient<IDataReaderStrategy, JsonDataReaderStrategy>()
                .AddTransient<IMessageHistoryManager, MessageHistoryManager>()
                .AddTransient<IMessageHistoryService, MessageHistoryService>()
                .BuildServiceProvider();

            var messageHistoryService = serviceProvider.GetService<IMessageHistoryService>();

            //TODO: read file name from configuration provider
            var messageHistory = messageHistoryService.Process("messages.json");

            //TODO: write data to different sources
            Console.WriteLine(messageHistory.UserId);
            Console.WriteLine(messageHistory.ExportDate);

            foreach (var conversation in messageHistory.Conversations)
            {
                Console.WriteLine(conversation.DisplayName);
                foreach (var message in conversation.MessageList)
                {
                    Console.WriteLine(message.From);
                    Console.WriteLine(message.Content);
                }
            }

            Console.ReadKey();
        }
    }
}
