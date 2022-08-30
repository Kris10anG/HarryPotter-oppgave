using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter_oppgave
{
    internal class HarryPotterCharacter
    {
        //Trylle, kjøpe ting, vise egen informasjon/ting,
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Damage { get; private set; }
        public string House { get; private set; }
        public int Money { get; private set; }
        public int MoreMoney { get; private set; }
        public bool IsAlive { get; private set; }
        public string QuidditchRole { get; private set; }
        public List<Item> Items { get; private set; }


        public HarryPotterCharacter(string name, int health, int damage, string house, int money, bool isalive, string quidditchRole)
        {
            Name = name;
            Health = health;
            Damage = damage;
            House = house;
            Money = money;
            MoreMoney = money;
            IsAlive = isalive;
            QuidditchRole = quidditchRole;
            Items = new List<Item>();
        }


        public void Buy(Item item)
        {
            Money -= item.Price;
            Items.Add(item);
        }

        public void ShowInformation()
        {
            foreach (var item in Items)
            {
                Console.WriteLine($"Mine items: {item.Name}");
            }
        }

        public int DoMathMagic(int number)
        {
            var magicalResult = number * number * number;
            MoreMoney += magicalResult;
            Money += MoreMoney;
            Console.WriteLine($"{Name} casted a spell. WizardMoney now have increased with {MoreMoney}");
            Console.WriteLine($"Now the total is {Money} WizardMoney");
            return magicalResult;
        }

        public void MakeFeatherFly(string spell)
        {
            if (spell == "vingardium leviosa")
            {
                Console.WriteLine($"Fjærden svever......");
            }
            else
            {
                Console.WriteLine($"Feil trylleformel, prøv igjen");
            }
        }
        public bool CheckItem()
        {
            var item = Items.FirstOrDefault(item => item.Name == "Phoenix staff");
            if (item.Name == "Phoenix staff")
            {
                Damage = 30;
                Console.WriteLine($"{Items} has an {item.Name}!\n\n" +
                                  $"Time to fight Voldemort!");
                return true;
            }
            return false;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} tok a hit. HP {Health}");
        }

        public void DealDamage(Voldemort voldemort)
        {

            voldemort.TakeDamage(Damage);
            //voldemort.CheckDeath();
            
        }

        public void IncreaseDamage(int damage)
        {
            Damage = damage;
            Console.WriteLine($"Damage has increased to {Damage}");
        }

        public void CheckDeath()
        {
            if (Health <= 0)
            {
                IsAlive = false;
                Console.WriteLine($"{Name} is DEAD!");

                //Environment.Exit(0);

            }

        }


        public void SendLetterWithOwl(Letter letterToSend, Voldemort voldemort)
        {
            
            voldemort.ReciveLetterFromOwl(letterToSend);
//Hva skal funksjonen gjøre her? Jo den skal sende et brev med ugle
//
        }
    }



}
