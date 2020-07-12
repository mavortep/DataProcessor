using DataProcessor.Domain.Models.Shared;

namespace DataProcessor.Contracts.Domain.Services
{
    public interface IMessageHistoryService
    {
        MessageHistory Process(string sourceName);
    }
}
