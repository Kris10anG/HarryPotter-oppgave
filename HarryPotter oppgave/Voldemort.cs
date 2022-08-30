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
        public List<Letter> Inventory { get; private set; }

        public Voldemort(string name, int health, bool isAlive)
        {
            Name = name;
            Health = health;
            IsAlive = isAlive;
            Inventory = new List<Letter>();
        }

        public void TakeDamage(int damage)
        {
            if (Health <= 0) return;
            Health -= damage;
            Console.WriteLine($"{Name} tok a hit! HP {Health}");
        }
        public int WizardDamage(int min, int max)
        {
            var random = new Random();
            var damage = random.Next(min, max);
            return damage;
        }

        public void DealDamageTo(HarryPotterCharacter character)
        {
            character.TakeDamage(WizardDamage(30, 51));
         
        }

        public void CheckDeath()
        {
            if (Health <= 0)
            {
                IsAlive = false;
                Console.WriteLine($"{Name} is DEAD!");
                //Environment.Exit(0);
                //return;

            }
            
        }

        public void ReciveLetterFromOwl(Letter letter)
        {
            Inventory.Add(letter);
        }

        public void ShowInventory()
        {
            foreach (var item in Inventory)
            {
                Console.WriteLine(item.Message);
            }
        }
    }
}
