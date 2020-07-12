using System;
using System.Collections.Generic;
using System.Text;

namespace DataProcessor.Domain.Models.Shared
{
    public class Message
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public DateTime OriginalArrivalTime { get; set; }
        public string MessageType { get; set; }
        public double Version { get; set; }
        public string Content { get; set; }
        public string ConversationId { get; set; }
        public string From { get; set; }
        public object Properties { get; set; }
        public object AmsReferences { get; set; }
    }
}
