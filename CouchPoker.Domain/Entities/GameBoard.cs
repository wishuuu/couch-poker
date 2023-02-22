﻿using System.Collections.Generic;

namespace CouchPoker.Domain.Entities;

public class GameBoard : BaseEntity
{
    public string Identifier { get; set; }
    public string ConnectionId { get; set; }
    public int MaxPlayers { get; set; }
    public int MinPlayers { get; set; }
    public virtual IEnumerable<Player> Players { get; set; }
    public virtual IEnumerable<Card> Cards { get; set; }
    public virtual IEnumerable<Card> CommunityCards { get; set; }
    public int ChipsOnBet { get; set; }
    public int StartChips { get; set; }
    public int CurrentPlayer { get; set; }
}