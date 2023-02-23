namespace CouchPoker.Domain.Dtos;

public class PlayerDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ConnectionId { get; set; }
    public int GameBoardId { get; set; }
    public PlayerStateDto PlayerState { get; set; }
}