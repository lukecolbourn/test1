using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging
{
    public static class MessageStorage
    {
        private static Queue<Message> Messages = new Queue<Message>();

        public static void RecordMessage(string name, string message)
        {
            if(Messages.Count >= 10)
            {
                Messages.Dequeue();
            }

            Messages.Enqueue(new Message(name, message));
        }

        public static IEnumerable<Message> GetTenMessages()
        {
            return Messages.OrderByDescending(a => a.Date).ToList();
        }
    }
}
