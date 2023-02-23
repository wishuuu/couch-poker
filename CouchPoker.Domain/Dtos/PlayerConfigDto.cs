using CouchPoker.Domain.Entities;

namespace CouchPoker.Domain.Dtos;

public class PlayerConfigDto
{
    public string Name { get; set; }
    public string ConnectionId { get; set; }
    public GameBoard GameBoard { get; set; }
    public int GameBoardId { get; set; }
    
    public PlayerConfigDto(string name, string connectionId, GameBoard gameBoard)
    {
        Name = name;
        ConnectionId = connectionId;
        GameBoard = gameBoard;
        GameBoardId = gameBoard.Id;
    }
}