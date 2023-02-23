using AutoMapper;
using CouchPoker.Domain.Dtos;
using CouchPoker.Domain.Entities;

namespace CouchPoker.AutoMapper;

public class PlayerProfile : Profile
{
    public PlayerProfile()
    {
        CreateMap<PlayerConfigDto, Player>()
            .ForMember(p => p.PlayerState, opt => opt.MapFrom((dto, p) => new PlayerState() {Player = p}));
        CreateMap<Player, PlayerDto>();
    }
}