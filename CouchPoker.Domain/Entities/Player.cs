using System.Collections.Generic;

namespace CouchPoker.Domain.Entities;

public class Player : BaseEntity
{
    public string Name { get; set; }
    public string ConnectionId { get; set; }
    public virtual PlayerState PlayerState { get; set; }
    public virtual GameBoard GameBoard { get; set; }
}