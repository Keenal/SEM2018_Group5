using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace TUTORized.Hubs
{
    public class ChatHub : Hub
    {
         public async Task NewMessage(string username, string message)
        {
            await Clients.All.SendAsync("messageReceived", username, message);
        }
    }
}