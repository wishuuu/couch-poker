using AutoMapper;
using CouchPoker.Domain.Dtos;
using CouchPoker.Domain.Entities;

namespace CouchPoker.AutoMapper;

public class CardProfile : Profile
{
    public CardProfile()
    {
        CreateMap<Card, CardDto>();
    }
}