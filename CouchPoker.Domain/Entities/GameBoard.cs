using System.Collections.Generic;

namespace CouchPoker.Domain.Entities;

public class GameBoard : BaseEntity
{
    public string Identifier { get; set; }
    public string ConnectionId { get; set; }
    public int MaxPlayers { get; set; }
    public int MinPlayers { get; set; }
    public virtual ICollection<Player> Players { get; set; } = new List<Player>();
    public virtual ICollection<Card> Cards { get; set; } = new List<Card>();
    public virtual ICollection<Card> CommunityCards { get; set; } = new List<Card>();
    public int ChipsOnBet { get; set; }
    public int StartChips { get; set; }
    public int CurrentPlayer { get; set; }
    public int StartingPlayer { get; set; }
}