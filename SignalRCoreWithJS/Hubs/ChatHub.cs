namespace SignalRCoreWithJS.Hubs;

public class ChatHub : Hub
{
    public async Task Send(string userName, string message, string lat, string lng)
    {
        await this.Clients.All.SendAsync("ReceiveMessage", userName, message, lat, lng);
    }
}
