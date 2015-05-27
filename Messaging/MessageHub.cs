using Microsoft.AspNet.SignalR;
using System.Linq;

namespace Messaging
{
    public class MessageHub : Hub
    {
        private string[] swears = new string[] { "shit", "fuck", "cunt" };

        public void Send(string name, string message)
        {
            if(swears.Any(a => message.Contains(a)))
            {
                Clients.All.swearAlert(name);
                return;
            }

            MessageStorage.RecordMessage(name, message);

            Clients.All.broadcast(name, message);
        }
    }
}
