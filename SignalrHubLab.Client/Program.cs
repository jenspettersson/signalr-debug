// See https://aka.ms/new-console-template for more information

using Microsoft.AspNetCore.SignalR.Client;

Console.WriteLine("Send message by pressing enter");
while (true)
{
    var readLine = Console.ReadKey();

    var hubConnection = new HubConnectionBuilder()
        .WithUrl("http://localhost:5067/hub")
        .Build();

    await hubConnection.StartAsync();

    var message = Guid.NewGuid().ToString().Substring(0, 8);
    Console.WriteLine($"Connection-id: {hubConnection.ConnectionId}: {message} - {hubConnection.State}");
    
    await hubConnection.SendAsync("TestMethod", message);

    //Without this, it doesn't deliver 100% of the SendAsync above.
    //await Task.Delay(1);
    
    await hubConnection.StopAsync();

}
