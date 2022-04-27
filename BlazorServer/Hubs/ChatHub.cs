using Microsoft.AspNetCore.SignalR; // SignalR is a wrapper around WebSockets

namespace BlazorServer.Hubs;

// This class acts as the server
public class ChatHub : Hub
{
    public Task SendMessage(string user, string message)
    {
        return Clients.All.SendAsync("RecieveMessage", user, message);
    }
}
