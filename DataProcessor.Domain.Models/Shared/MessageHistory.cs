using System;
using System.Collections.Generic;
using System.Text;

namespace DataProcessor.Domain.Models.Shared
{
    public class MessageHistory
    {
        public string UserId { get; set; }

        public DateTime ExportDate { get; set; }

        public List<Conversation> Conversations { get; set; }
    }
}
