using AutoMapper;
using CouchPoker.Domain.Dtos;
using CouchPoker.Domain.Entities;

namespace CouchPoker.AutoMapper;

public class GameBoardProfile : Profile
{
    public GameBoardProfile()
    {
        CreateMap<GameBoardConfigDto, GameBoard>()
            .ForMember(dest => dest.Identifier, opt => opt.MapFrom(src => new Random().Next()%1000000));
        CreateMap<GameBoard, GameBoardDto>();
    }
}