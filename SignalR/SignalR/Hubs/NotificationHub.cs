using Microsoft.AspNetCore.SignalR;
using System.Security.Cryptography.X509Certificates;

namespace SignalR.Hubs
{
    public class NotificationHub:Hub
    {
        /*public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("Receive message", message);
        }*/
    }

}
