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
        public List<Item> Pets { get; private set; }
        public List<Wand> Wands { get; private set; }
        public List<Broom> Brooms { get; private set; }

        public MagicStore()
        {
            Pets = new List<Item>
            {
                new Item("Cat", 10, "a", 0),
                new Item("Owl", 20, "b", 0),
                new Item("Mouse", 30, "c", 0),

            };
            Wands = new List<Wand>
            {
                new Wand("Phoenix staff", 100, "d", 30),
                new Wand("Unicorn wand", 200, "e", 40),
                new Wand("Magic wand", 300, "f", 50),
            };
            Brooms = new List<Broom>
            {
                new Broom("Nimbus 2000", 1000, 0,"nimbus"),
                new Broom("Firebolt", 2000, 0, "firebolt"),
                new Broom("Turbo XXX", 500, 0, "turbo"),
            };
        }

        public void ShowPetsAndWands(string chooseCategory)
        {
            switch (chooseCategory)
            {
                case "pet":
                    foreach (var pet in Pets)
                    {
                        Console.WriteLine($"We sell {pet.Name}, Price {pet.Price}, Keypress {pet.Keypress}");
                    }
                    break;
                case "wand":
                    foreach (var wand in Wands)
                    {
                        Console.WriteLine($"We sell {wand.Name}, Price {wand.Price}, Damage {wand.Damage}Keypress {wand.Keypress}");

                    }
                    break;
                case "broom":
                    foreach (var broom in Brooms)
                    {
                        Console.WriteLine($"We sell {broom.Name}, Price {broom.Price}, Keypress {broom.Keypress}");

                    }
                    break;
            }
        }

        public void SellMagicalItems(string keypress, HarryPotterCharacter character, string whitchShop)
        {
            Item sellItem;
            if (whitchShop == "pet")
            {
                sellItem = Pets.FirstOrDefault(pet => pet.Keypress == keypress);
            }

            
            else if (whitchShop == "broom")
            {
                sellItem = Brooms.FirstOrDefault(broom => broom.Keypress == keypress);

            }
            else 
            {

                sellItem = Wands.FirstOrDefault(wand => wand.Keypress == keypress);
            }

            if (keypress == sellItem.Keypress && character.Money >= sellItem.Price)
            {
                character.Buy(sellItem);
                Console.WriteLine($"{character.Name} bought {sellItem.Name}. \n" +
                                  $"{character.Name} now has {character.Money} Wizardmoney left");
                //if (whitchShop == "wand")
                //{
                //    Wand boughtWand = Wands.FirstOrDefault(wand => wand.Keypress == keypress);
                //    character.IncreaseDamage(boughtWand.Damage);
                //}
            }
            else if (character.Money < sellItem.Price)
            {
                Console.WriteLine($"Du har ikke nok penger, kom deg ut av butikken!");
                Environment.Exit(0);
            }

        }
    }
}
