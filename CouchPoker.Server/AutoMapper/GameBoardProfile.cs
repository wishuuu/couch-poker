using AutoMapper;
using CouchPoker.Domain.Dtos;
using CouchPoker.Domain.Entities;

namespace CouchPoker.Domain.MapperProfile;

public class GameBoardProfile : Profile
{
    public GameBoardProfile()
    {
        CreateMap<GameConfigDto, GameBoard>()
            .ForMember(dest => dest.Players, opt => opt.MapFrom(src => new List<Player>()))
            .ForMember(dest => dest.Cards, opt => opt.MapFrom(src => new List<Card>()))
            .ForMember(dest => dest.CommunityCards, opt => opt.MapFrom(src => new List<Card>()))
            .ForMember(dest => dest.Identifier, opt => opt.MapFrom(src => new Random().Next()%1000000));
    }
}