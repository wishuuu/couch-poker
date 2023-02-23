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
    
    public static void DealCards(this GameBoard gameBoard)
    {
        for (int i = 0; i < 2; i++)
        {
            foreach (var player in gameBoard.Players)
            {
                player.PlayerState.Cards.Add(gameBoard.Cards.First());
                gameBoard.Cards.Remove(gameBoard.Cards.First());
            }
        }
    }
    
    public static void DealFlop(this GameBoard gameBoard)
    {
        for (int i = 0; i < 3; i++)
        {
            gameBoard.CommunityCards.Add(gameBoard.Cards.First());
            gameBoard.Cards.Remove(gameBoard.Cards.First());
        }
    }
    
    public static void DealTurn(this GameBoard gameBoard)
    {
        gameBoard.CommunityCards.Add(gameBoard.Cards.First());
        gameBoard.Cards.Remove(gameBoard.Cards.First());
    }
}