using CouchPoker.Domain.Dtos;
using CouchPoker.Domain.Entities;
using CouchPoker.Game;
using CouchPoker.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace CouchPoker.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GameBoardController : ControllerBase
{
    private readonly GameInitializer _gameInitializer;
    private readonly UnitOfWork _unitOfWork;

    public GameBoardController(GameInitializer gameInitializer, UnitOfWork unitOfWork)
    {
        _gameInitializer = gameInitializer;
        _unitOfWork = unitOfWork;
    }

    [HttpPost]
    [Route("initialize")]
    public IActionResult Initialize(GameConfigDto dto)
    {
        var gameBoard = _gameInitializer.Initialize(dto);
        _unitOfWork.Context.Add(gameBoard);
        _unitOfWork.Save();
        return Ok(gameBoard.Identifier);
    }
    
    [HttpGet]
    [Route("get")]
    public IActionResult Get()
    {
        var gameBoard = _unitOfWork.Context.Set<GameBoard>().FirstOrDefault();
        return Ok(gameBoard);
    }
}