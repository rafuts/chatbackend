using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
{
    public async Task Send(string name, string message)
    {
        await Clients.All.SendAsync("test", name, message);
    }
}