using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter_oppgave
{
    internal class Wand : Item
    {
        public int Damage { get; private set; }

        public Wand(string name, int price, string keypress, int damage) : base(name, price, keypress, damage)
        {
            Damage = damage;
        }
    }
}
