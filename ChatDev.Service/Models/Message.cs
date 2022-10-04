using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatDev.Service.Models
{
    public class Message
    {
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string SenderName { get; set; }
    }
}
