

using Atrribute.Authorize;
using Microsoft.AspNet.SignalR;



namespace SignalRService
{
    public class ChatHub: Hub
    {
       
        public void Send(string message)
        {
           
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage( message);
        }
    }
}