using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesInventory.Models
{
    public class GameTx : Launcher
    {
        public DateOnly PurchaseDate { get; }
        public decimal Price { get; }
        public string MediaType { get; }

        public GameTx(DateOnly purchaseDate, decimal price, string mediaType, string nameGame, string namePlatform, string nameStore, string nameLauncher) : base(nameLauncher, nameStore, namePlatform, nameGame)
        {
            PurchaseDate = purchaseDate;
            Price = price;
            MediaType = !string.IsNullOrWhiteSpace(mediaType) ? mediaType : throw new ArgumentException("Media type cannot be null or empty.");

        }
    }
}
