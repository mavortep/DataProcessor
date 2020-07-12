using System;
using System.Collections.Generic;
using System.Text;

namespace DataProcessor.Domain.Models.Shared
{
    public class Conversation
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public long Version { get; set; }
        public Properties Properties { get; set; }
        public object ThreadProperties { get; set; }
        public List<Message> MessageList { get; set; }
    }
}
