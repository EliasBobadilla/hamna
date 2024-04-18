using Web.Client.Models;

namespace Web.Client;

public static class WebClient
{
    private static readonly List<Game> games = new();

    public static Game[] GetGames()
    {
        return games.ToArray();
    }

    public static void AddGame(Game game)
    {
        game.Id = games.Max(game => game.Id + 1);
        games.Add(game);
    }

    public static Game GetGame(int id)
    {
        return games.Find(game => game.Id == id) ?? throw new Exception("Could not find game!");
    }

    public static void UpdateGame(Game updatedGame)
    {
        Game existingGame = GetGame(updatedGame.Id);
        existingGame.Name = updatedGame.Name;
        existingGame.Genre = updatedGame.Genre;
        existingGame.Price = updatedGame.Price;
        existingGame.ReleaseDate = updatedGame.ReleaseDate;
    }

    public static void DeleteGame(int id)
    {
        Game game = GetGame(id);
        games.Remove(game);
    }
}