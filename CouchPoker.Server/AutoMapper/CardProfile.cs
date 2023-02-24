using AutoMapper;
using CouchPoker.Domain.Dtos;
using CouchPoker.Domain.Entities;

namespace CouchPoker.AutoMapper;

public class CardProfile : Profile
{
    public CardProfile()
    {
        CreateMap<Card, CardDto>();
        CreateMap<Card, pheval.Card>()
            .ForMember(pc => pc.id, opt => opt.MapFrom(c => (int) c.Suit * 4 + (int) c.Value - 2));
    }
}