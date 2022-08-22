using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter_oppgave
{
    internal class MagicStore
    {
        public List<Item> Items { get; private set; }
        public MagicStore()
        {
            //selger ting, 
            Items = new List<Item>()
            {
                new Item("Cat", 10, "a"),
                new Item("Owl", 20, "b"),
                new Item("Mouse", 30, "c"),
                new Item("Phoenix staff", 100, "d"),
                new Item("Unicorn wand", 200, "e"),
                new Item("Magic wand", 300, "f"),

            };
        }

        public void ShowItems()
        {
            foreach (var Item in Items)
            {
                Console.WriteLine($"We sell {Item.Name}, Price {Item.Price}, Keypress {Item.Keypress}"); 
            }
        }
        public void SellMagicalItems(string keypress, HarryPotterCharacter character)
        {
            var item = Items.FirstOrDefault(item => item.Keypress == keypress);
            if (keypress == item.Keypress && character.Money >= item.Price)
            {
                character.Buy(item);
                Console.WriteLine($"{character.Name} bought {item.Name}. \n" +
                                  $"{character.Name} now has {character.Money} Wizardmoney left");
            }

            else if (character.Money < item.Price)
            {
                Console.WriteLine($"Du har ikke nok penger, kom deg ut av butikken!");
                Environment.Exit(0);
            }

        }
    }
}
