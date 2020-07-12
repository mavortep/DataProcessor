using System;
using System.Collections.Generic;
using System.Text;

namespace DataProcessor.Domain.Models.Shared
{
    public class Properties
    {
        public bool ConversationBlocked { get; set; }
        public DateTime? LastImReceivedTime { get; set; }
        public string ConsumptionHorizon { get; set; }
        public string ConversationStatus { get; set; }
    }
}
