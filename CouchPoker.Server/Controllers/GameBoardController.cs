using AutoMapper;
using CouchPoker.Domain.Dtos;
using CouchPoker.Domain.Entities;
using CouchPoker.Game;
using CouchPoker.Hubs;
using CouchPoker.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace CouchPoker.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GameBoardController : ControllerBase
{
    private readonly GameInitializer _gameInitializer;
    private readonly UnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IHubContext<GameBoardHub> _gameBoardHubContext;
    private readonly IHubContext<PlayerHub> _playerHubContext;

    public GameBoardController(GameInitializer gameInitializer, UnitOfWork unitOfWork, IMapper mapper,
        IHubContext<GameBoardHub> gameBoardHubContext, IHubContext<PlayerHub> playerHubContext)
    {
        _gameInitializer = gameInitializer;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _gameBoardHubContext = gameBoardHubContext;
        _playerHubContext = playerHubContext;
    }

    [HttpPost]
    [Route("initialize")]
    public IActionResult Initialize(GameBoardConfigDto dto)
    {
        var gameBoard = _gameInitializer.Initialize(dto);
        _unitOfWork.Context.Add(gameBoard);
        _unitOfWork.Save();

        _gameBoardHubContext.Groups.AddToGroupAsync(gameBoard.ConnectionId, gameBoard.Identifier).Wait();

        return Ok(gameBoard.Identifier);
    }

    [HttpPost]
    [Route("joinBoardAsPlayer")]
    public IActionResult JoinBoardAsPlayer(string identifier, string username, string connectionId)
    {
        var gameBoard = _unitOfWork.Context.Set<GameBoard>().FirstOrDefault(board => board.Identifier == identifier);
        if (gameBoard == null) return NotFound();
        var player = _gameInitializer.CreatePlayer(username, connectionId, gameBoard);
        gameBoard.Players.Add(player);
        _unitOfWork.Save();
        return Ok(_mapper.Map<PlayerDto>(player));
    }

    [HttpGet]
    [Route("getBoardByIdentifier")]
    public IActionResult GetBoardByIdentifier(string identifier)
    {
        var gameBoard = _unitOfWork.Context.Set<GameBoard>().FirstOrDefault(board => board.Identifier == identifier);
        return gameBoard != null ? Ok(_mapper.Map<GameBoardDto>(gameBoard)) : NotFound();
    }
}