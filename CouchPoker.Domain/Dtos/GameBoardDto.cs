namespace CouchPoker.Domain.Dtos;

public class GameBoardDto
{
    public int Id { get; set; }
    public string Identifier { get; set; }
    public string ConnectionId { get; set; }
    public virtual ICollection<PlayerDto> Players { get; set; }
    public virtual ICollection<CardDto> Cards { get; set; }
    public virtual ICollection<CardDto> CommunityCards { get; set; }
}