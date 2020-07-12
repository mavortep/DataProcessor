using DataProcessor.Domain.Models.Shared;

namespace DataProcessor.Contracts.Domain.Strategies
{
    public interface IDataReaderStrategy
    {
        MessageHistory Read(string fileName);
    }
}
