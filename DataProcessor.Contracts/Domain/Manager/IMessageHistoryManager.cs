using DataProcessor.Domain.Models.Shared;

namespace DataProcessor.Contracts.Domain.Manager
{
    public interface IMessageHistoryManager
    {
        MessageHistory Get(string sourceName);
    }
}
