using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GamesInventory.Models
{
    public class Platform : Games
    {
        public string NamePlatform { get; }
        public Platform(string? namePlatform, string nameGame) : base(nameGame)
        {
            NamePlatform = !string.IsNullOrWhiteSpace(namePlatform) ? 
                namePlatform : throw new ArgumentException("Platform name cannot be null or empty.");
        }
    }
}
