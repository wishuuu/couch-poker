using System.Collections.Generic;

namespace CouchPoker.Domain.Entities;

public class GameBoard : BaseEntity
{
    public string Name { get; set; }
    public string Password { get; set; }
    public string ConnectionId { get; set; }
    public int MaxPlayers { get; set; }
    public int MinPlayers { get; set; }
    public IEnumerable<Player> Players { get; set; }
    public IEnumerable<Card> Cards { get; set; }
    public IEnumerable<Card> CommunityCards { get; set; }
    public int ChipsOnBet { get; set; }
    public int StartChips { get; set; }
}