using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesInventory.Models
{
    public class Store : Platform
    {
        public string NameStore { get; }

        public Store(string nameStore, string namePlatform, string nameGame) 
            : base(namePlatform, nameGame) 
        {
            NameStore = !string.IsNullOrWhiteSpace(nameStore) ? nameStore : throw new ArgumentException("Store name cannot be null or empty.");
        }
    }
}
