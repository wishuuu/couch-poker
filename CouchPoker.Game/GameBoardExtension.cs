using CouchPoker.Domain.Entities;

namespace CouchPoker.Game;

public static class GameBoardExtension
{
    public static void ShuffleCards(this GameBoard gameBoard)
    {
        foreach (var player in gameBoard.Players)
        {
            player.PlayerState.Cards = new List<Card>();
        }
        
        gameBoard.Cards = new List<Card>();
        for (int i = 0; i < 4; i++)
        for (int j = 2; j < 15; j++)
            gameBoard.Cards.Add(new Card() {Suit = (CardSuit) i, Value = (CardValue) j, GameBoardId = gameBoard.Id});

        gameBoard.Cards = gameBoard.Cards.OrderBy(card => Guid.NewGuid()).ToList();
    }
}