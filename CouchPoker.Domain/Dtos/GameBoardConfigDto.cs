namespace CouchPoker.Domain.Dtos;

public class GameBoardConfigDto
{
    public string ConnectionId { get; set; }
    public int MaxPlayers { get; set; }
    public int MinPlayers { get; set; }
    public int StartChips { get; set; }
}