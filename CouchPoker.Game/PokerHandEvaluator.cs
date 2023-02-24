using AutoMapper;
using CouchPoker.Domain.Entities;

namespace CouchPoker.Game;

public class PokerHandEvaluator
{
    private readonly IMapper _mapper;

    public PokerHandEvaluator(IMapper mapper)
    {
        _mapper = mapper;
    }

    public int EvaluateHand(IEnumerable<Card> cards)
    {
        var newCards = _mapper.Map<IEnumerable<pheval.Card>>(cards).ToArray();
        return pheval.Eval.Eval7Cards(newCards);
    }
}