using DataProcessor.Contracts.Domain.Manager;
using DataProcessor.Contracts.Domain.Services;
using DataProcessor.Domain.Models.Shared;

namespace DataProcessor.Domain.Services
{
    public class MessageHistoryService : IMessageHistoryService
    {
        private readonly IMessageHistoryManager _messageHistoryManager;
        public MessageHistoryService(IMessageHistoryManager messageHistoryManager)
        {
            _messageHistoryManager = messageHistoryManager;
        }

        public MessageHistory Process(string sourceName)
        {
            return _messageHistoryManager.Get(sourceName);
        }
    }
}
