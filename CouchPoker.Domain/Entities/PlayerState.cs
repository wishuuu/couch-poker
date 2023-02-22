namespace CouchPoker.Domain.Entities;

public class PlayerState : BaseEntity
{
    public int PlayerId { get; set; }
    public virtual Player Player { get; set; }
    public virtual GameBoard GameBoard { get; set; }
    public bool IsFolded { get; set; }
    public bool IsAllIn { get; set; }
    public int ChipsOnBet { get; set; }
    public int ChipsOnHand { get; set; }
    public virtual IEnumerable<Card> Cards { get; set; }
}