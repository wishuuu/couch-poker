using AutoMapper;
using CouchPoker.Domain.Dtos;
using CouchPoker.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace CouchPoker.Game;

public class GameInitializer
{
    private readonly ILogger<GameInitializer> _logger;
    private readonly IMapper _mapper;

    public GameInitializer(ILogger<GameInitializer> logger, IMapper mapper)
    {
        _logger = logger;
        _mapper = mapper;
    }

    public GameBoard Initialize(GameBoardConfigDto gameBoardConfigDto)
    {
        _logger.LogInformation("Initializing game board");
        var gameBoard = _mapper.Map<GameBoard>(gameBoardConfigDto);
        return gameBoard;
    }

    public Player CreatePlayer(string name, string connectionId, GameBoard gameBoard)
    {
        _logger.LogInformation("Creating a new player");
        var playerConfigDto = new PlayerConfigDto(name, connectionId, gameBoard);
        var player = _mapper.Map<Player>(playerConfigDto);
        return player;
    }
}