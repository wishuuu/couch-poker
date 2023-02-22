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

    public GameBoard Initialize(GameConfigDto gameConfigDto)
    {
        _logger.LogInformation("Initializing game board");
        var gameBoard = _mapper.Map<GameBoard>(gameConfigDto);
        return gameBoard;
    }
}