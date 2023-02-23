using Microsoft.AspNetCore.SignalR;

namespace CouchPoker.Hubs;

public class PlayerHub : Hub
{
    private readonly ILogger<PlayerHub> _logger;

    public PlayerHub(ILogger<PlayerHub> logger)
    {
        _logger = logger;
    }
    
    public override Task OnConnectedAsync()
    {
        _logger.LogInformation("Connected {ConnectionId}", Context.ConnectionId);
        return base.OnConnectedAsync();
    }
    
    public override Task OnDisconnectedAsync(Exception? exception)
    {
        _logger.LogInformation("Disconnected {ConnectionId}", Context.ConnectionId);
        if (exception != null)
        {
            _logger.LogError(exception, "Disconnected {ConnectionId}", Context.ConnectionId);
        }
        return base.OnDisconnectedAsync(exception);
    }
}