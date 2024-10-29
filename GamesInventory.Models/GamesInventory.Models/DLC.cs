using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesInventory.Models
{
    public class DLC : Games
    {
        public Games MainGame { get; }

        public DLC(string nameDlc, Games mainGame) : base(nameDlc)
        {
            MainGame = mainGame ?? throw new ArgumentException("A main game is required for a DLC.");
        }
    }
}
