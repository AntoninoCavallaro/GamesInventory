using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesInventory.Models
{
    public class Launcher : Store
    {
        public string NameLauncher { get; }

        public Launcher(string nameLauncher, string nameStore, string namePlatform, string nameGame) 
            : base(nameStore, namePlatform, nameGame)
        {
            NameLauncher = !string.IsNullOrWhiteSpace(nameLauncher) ? nameLauncher : throw new ArgumentException("Launcher name cannot be null or empty.");
        }
    }
}
