namespace CouchPoker.Domain.Entities;

public class Player : BaseEntity
{
    public string Name { get; set; }
    public string ConnectionId { get; set; }
    public int Chips { get; set; }
    public IEnumerable<Card> CardsOnHand { get; set; }
}