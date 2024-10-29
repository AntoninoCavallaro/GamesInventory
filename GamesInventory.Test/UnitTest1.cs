using Xunit;
using GamesInventory.Models;
using FluentAssertions;

public class GamesInventoryTests
{
    [Theory]
    [InlineData("Cyberpunk 2077", "PC", "Steam", "Epic Launcher", "2023-01-01", 59.99, "Digital")]
    //[InlineData("", "PC", "Steam", "Epic Launcher", "2023-01-01", 59.99, "Digital")]
    //[InlineData("Cyberpunk 2077", "", "Steam", "Epic Launcher", "2023-01-01", 59.99, "Digital")]
    public void GameTx_Should_Have_Correct_Values(
        string nameGame,
        string namePlatform,
        string nameStore,
        string nameLauncher,
        string date,
        decimal price,
        string mediaType)
    {
        // Arrange
        var purchaseDate = DateOnly.Parse(date);

        // Act
        var gameTx = new GameTx(purchaseDate, price, mediaType, nameGame, namePlatform, nameStore, nameLauncher);

        // Assert
        gameTx.NameGame.Should().Be(nameGame);
        gameTx.NamePlatform.Should().Be(namePlatform);
        gameTx.NameStore.Should().Be(nameStore);
        gameTx.NameLauncher.Should().Be(nameLauncher);
        gameTx.PurchaseDate.Should().Be(purchaseDate);
        gameTx.Price.Should().Be(price);
        gameTx.MediaType.Should().Be(mediaType);
    }
}
public class DLCTests
{
    [Theory]
    [InlineData("Phantom Liberty", "Cyberpunk 2077")]
    [InlineData("Hearts of Stone", "The Witcher 3")]
    public void Dlc_Should_Have_Correct_MainGame(string dlcName, string mainGameName)
    {
        // Arrange
        var mainGame = new Games(mainGameName);

        // Act
        var dlc = new DLC(dlcName, mainGame);

        // Assert
        dlc.NameGame.Should().Be(dlcName);
        dlc.MainGame.Should().Be(mainGame);
        dlc.MainGame.NameGame.Should().Be(mainGameName);
    }
}
