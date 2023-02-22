namespace CouchPoker.Domain.Dtos;

public class GameConfigDto
{
    public string ConnectionId { get; set; }
    public int MaxPlayers { get; set; }
    public int MinPlayers { get; set; }
    public int StartChips { get; set; }
}