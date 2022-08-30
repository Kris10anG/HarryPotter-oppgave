using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter_oppgave
{
    internal class Broom : Item
    {
        public string Name { get;private set; }
        public int Speed { get;private set; }
        public int Price { get;private set; }
        public string Keypress { get;private set; }

        public Broom(string name, int speed, int price, string keypress) : base(name, price, keypress, 0)
        {
            Name = name;
            Speed = speed;
            Price= price;
            Keypress = keypress;
        }
    }
}
