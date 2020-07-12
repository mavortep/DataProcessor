using DataProcessor.Contracts.Domain.Manager;
using DataProcessor.Contracts.Domain.Services;
using DataProcessor.Domain.Models.Configuration;
using DataProcessor.Domain.Models.Shared;
using Microsoft.Extensions.Options;

namespace DataProcessor.Domain.Services
{
    public class MessageHistoryService : IMessageHistoryService
    {
        private readonly IMessageHistoryManager _messageHistoryManager;
        private readonly IOptions<ApplicationConfiguration> _options;
        public MessageHistoryService(IMessageHistoryManager messageHistoryManager,
            IOptions<ApplicationConfiguration> options)
        {
            _messageHistoryManager = messageHistoryManager;
            _options = options;
        }

        public MessageHistory Process()
        {
            var sourceName = _options.Value.SourceFileName;

            return sourceName != null ?_messageHistoryManager.Get(sourceName) : null;
        }
    }
}
