using System;

namespace ChatDev.Models
{
    public class Message
    {
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string SenderName { get; set; }
    }
}
