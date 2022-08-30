using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter_oppgave
{
    internal class Item
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public string Keypress { get; private set; }

        public Item(string name, int price, string keypress, int damage)
        {
            Name = name;
            Price = price;
            Keypress = keypress;
        }
    }
}
