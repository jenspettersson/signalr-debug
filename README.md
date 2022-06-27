# To reproduce

Using a terminal/command line:

1. Start hub: `src/SignalrHubLab` > `dotnet run`
2. Start client: `src/SignalrHub.Client` > `dotnet run`
3. Press any key to trigger a connection start -> message sent -> connection closed
4. Look for gaps in the logs in the Hub project similar to this:

![image](https://user-images.githubusercontent.com/125493/175952918-82f114ac-a98e-4776-ba6e-eae7c86fd372.png)
