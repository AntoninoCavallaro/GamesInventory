using System.Xml.Linq;

namespace GamesInventory.Models;

public class Games
{
    public string NameGame { get; }
    public string? Slug { get; }

    public Games(string nameGame)
    {
        NameGame = !string.IsNullOrWhiteSpace(nameGame) ? 
            nameGame : throw new ArgumentException("Game name cannot be null or empty.");

        Slug = nameGame.Replace(" ", "-");
    }
}
