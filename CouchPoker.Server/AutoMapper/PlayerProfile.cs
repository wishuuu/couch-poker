using AutoMapper;
using CouchPoker.Domain.Dtos;
using CouchPoker.Domain.Entities;

namespace CouchPoker.AutoMapper;

public class PlayerProfile : Profile
{
    public PlayerProfile()
    {
        CreateMap<PlayerConfigDto, Player>();
        CreateMap<Player, PlayerDto>();
    }
}