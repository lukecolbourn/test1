using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging
{
    public class Message
    {
        public Message(string name, string message)
        {
            this.Name = name;
            this.MessageText = message;
            this.Date = DateTime.UtcNow;
        }

        public string Name { get; set; }

        public string MessageText { get; set; }

        public DateTime Date { get; set; }
    }
}
