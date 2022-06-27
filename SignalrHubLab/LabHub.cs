using Microsoft.AspNetCore.SignalR;

namespace SignalrHubLab;

public class LabHub : Hub
{
    private readonly ILogger<LabHub> _logger;

    public LabHub(ILogger<LabHub> logger)
    {
        _logger = logger;
    }

    public override Task OnConnectedAsync()
    {
        _logger.LogWarning($"Connected: {Context.ConnectionId}");
        return Task.CompletedTask;
    }

    public override Task OnDisconnectedAsync(Exception exception)
    {
        _logger.LogWarning($"Disconnected: {Context.ConnectionId}");
        return Task.CompletedTask;
    }

    public async Task TestMethod(string message)
    {
        _logger.LogWarning($"========================================================== : {message}");
        await Clients.All.SendAsync("Test", message);
    }
}
