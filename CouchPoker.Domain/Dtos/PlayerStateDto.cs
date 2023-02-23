namespace CouchPoker.Domain.Dtos;

public class PlayerStateDto
{
    public int PlayerId { get; set; }
    public bool IsFolded { get; set; }
    public bool IsAllIn { get; set; }
    public int ChipsOnBet { get; set; }
    public int ChipsOnHand { get; set; }
    public virtual ICollection<CardDto> Cards { get; set; } 
}