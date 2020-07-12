using DataProcessor.Contracts.Domain.Manager;
using DataProcessor.Contracts.Domain.Strategies;
using DataProcessor.Domain.Models.Shared;

namespace DataProcessor.Domain.Managers
{
    public class MessageHistoryManager : IMessageHistoryManager
    {
        private readonly IDataReaderStrategy _dataReaderStrategy;
        public MessageHistoryManager(IDataReaderStrategy dataReaderStrategy)
        {
            _dataReaderStrategy = dataReaderStrategy;
        }

        public MessageHistory Get(string sourceName)
        {
            return _dataReaderStrategy.Read(sourceName);
        }
    }
}
