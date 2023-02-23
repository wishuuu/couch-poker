using CouchPoker.Domain.Entities;
using CouchPoker.Infrastructure;
using Microsoft.AspNetCore.SignalR;

namespace CouchPoker.Hubs;

public class GameBoardHub : Hub
{
    private readonly ILogger<GameBoardHub> _logger;

    public GameBoardHub(ILogger<GameBoardHub> logger)
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