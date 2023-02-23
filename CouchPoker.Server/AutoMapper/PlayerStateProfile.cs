using AutoMapper;
using CouchPoker.Domain.Dtos;
using CouchPoker.Domain.Entities;

namespace CouchPoker.AutoMapper;

public class PlayerStateProfile : Profile
{
    public PlayerStateProfile()
    {
        CreateMap<PlayerState, PlayerStateDto>();
    }
}