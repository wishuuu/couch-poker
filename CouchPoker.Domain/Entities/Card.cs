namespace CouchPoker.Domain.Entities;

public class Card : BaseEntity
{
    public string Name { get; set; }
    public CardSuit Suit { get; set; }
    public int Value { get; set; }
}

public enum CardSuit
{
    Clubs,
    Diamonds,
    Hearts,
    Spades
}