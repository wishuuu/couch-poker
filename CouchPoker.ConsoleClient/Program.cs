using CouchPoker.Domain.Dtos;
using Flurl.Http;
using Microsoft.AspNetCore.SignalR.Client;

const string signalrServerAddress = "https://localhost:2137/api/signalr/gameBoardHub";
const string apiServerAddress = "https://localhost:2137/api/gameBoard/initialize";

var connection = new HubConnectionBuilder()
    .WithUrl(signalrServerAddress)
    .WithAutomaticReconnect()
    .Build();

await connection.StartAsync();

var gameBoardConfig = new GameBoardConfigDto()
{
    ConnectionId = connection.ConnectionId ?? throw new Exception("SignalR connection id is null"),
    MaxPlayers = 8,
    MinPlayers = 2,
    StartChips = 1000
};

var gameBoardIdentifier = await apiServerAddress
    .PostJsonAsync(gameBoardConfig)
    .ReceiveJson<string>();
    
Console.WriteLine($"Game board identifier: {gameBoardIdentifier}");