using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter_oppgave
{
    internal class Voldemort 
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public bool IsAlive { get; private set; }

        public Voldemort(string name, int health, bool isAlive)
        {
            Name = name;
            Health = health;
            IsAlive = isAlive;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} tok a hit! HP {Health}");
        }
    }
}
