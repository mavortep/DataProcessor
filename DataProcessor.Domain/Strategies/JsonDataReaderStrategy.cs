using DataProcessor.Contracts.Domain.Strategies;
using DataProcessor.Domain.Models.Shared;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace DataProcessor.Domain.Strategies
{
    public class JsonDataReaderStrategy : DataReaderStrategyBase, IDataReaderStrategy
    {
        public MessageHistory Read(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return null;
            }

            var jsonString = File.ReadAllText(fileName, Encoding.UTF8);

            return JsonConvert.DeserializeObject<MessageHistory>(jsonString);
        }
    }
}
