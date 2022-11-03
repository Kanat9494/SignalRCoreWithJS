namespace SignalRCoreWithJS.Hubs;

public class ChatHub : Hub
{
    public async Task Send(string userName, string message)
    {
        await this.Clients.All.SendAsync("ReceiveMessage", userName, message);
    }
}
