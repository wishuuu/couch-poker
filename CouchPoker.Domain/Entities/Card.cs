namespace CouchPoker.Domain.Entities;

public class Card : BaseEntity
{
    public CardSuit Suit { get; set; }
    public CardValue Value { get; set; }
    public int GameBoardId { get; set; }
    public virtual GameBoard GameBoard { get; set; }
}

public enum CardSuit
{
    Clubs,
    Diamonds,
    Hearts,
    Spades
}

public enum CardValue
{
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10,
    Jack = 11,
    Queen = 12,
    King = 13,
    Ace = 14
}