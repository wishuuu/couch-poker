using CouchPoker.Domain.Entities;

namespace CouchPoker.Domain.Dtos;

public class CardDto
{
    public CardSuit Suit { get; set; }
    public CardValue Value { get; set; }
    public int GameBoardId { get; set; }
}