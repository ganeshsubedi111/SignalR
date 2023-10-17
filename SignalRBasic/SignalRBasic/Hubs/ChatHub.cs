using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRBasic.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendmessageToAll(string user,string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message); ;
        }

    }
}
