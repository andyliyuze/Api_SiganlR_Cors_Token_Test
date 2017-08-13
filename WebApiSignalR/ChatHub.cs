using Microsoft.AspNet.SignalR;
 
 
using WebApiSignalR.Atrribute;
 

namespace WebApiSignalR
{
    public class ChatHub: Hub
    {
        [HubAuthorize]
        public void Send(string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage( message);
        }
    }
}