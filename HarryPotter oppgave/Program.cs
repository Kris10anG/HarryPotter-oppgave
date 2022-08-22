using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HarryPotter_oppgave
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var HarryPotterCharacter = new HarryPotterCharacter("Kris10an", 200, 0, "Gryffindor", 100, true);
            var voldemortCharacter = new Voldemort($"Voldemort", 100, true);

            var magicstore = new MagicStore();
            
            
            //var question = Console.ReadLine();
            while (true)
            {
                Console.WriteLine($"Hello {HarryPotterCharacter.Name}! Press y to see your stats," +
                                  $" u for going to the Magic store, i for some Moneymagic" +
                                  $", o for some epic magic!, \n" +
                                  $"p for exit!");
                var command = Console.ReadLine();

            switch (command)
                {
                    case "y":
                        HarryPotterCharacter.ShowInformation();

                        Console.WriteLine($"Name: {HarryPotterCharacter.Name}\n House: {HarryPotterCharacter.House}\n" +
                        $"WizardMoney {HarryPotterCharacter.Money}\n");
                        
                        break;

                    case "u":
                    {
                        magicstore.ShowItems();
                        Console.WriteLine($"What do you want to buy?");
                        var question = Console.ReadLine();

                        magicstore.SellMagicalItems(question, HarryPotterCharacter);
                        break;
                    }
                    case "i":
                        var mathQuestion = Console.ReadLine();

                        var magicalNumber = Convert.ToInt32(mathQuestion);
                        
                        var mathSpell =  HarryPotterCharacter.DoMathMagic(magicalNumber);
                        Console.WriteLine(mathSpell);
                        break;
                    case "o":
                        Console.WriteLine($"Kom igjen {HarryPotterCharacter.Name}!" +
                                          $"Bruk dine magiske trylleevner og få fjærden til å sveve...\n" +
                                          $"Hint (vingardium leviosa)");

                        var spellQuestion = Console.ReadLine();

                        HarryPotterCharacter.MakeFeatherFly(spellQuestion);
                        break;
                    case "p":
                        Environment.Exit(0);
                        break;
                    case "battle":
                        while (!HarryPotterCharacter.IsAlive || !voldemortCharacter.IsAlive)
                        {
                            WizardFight(HarryPotterCharacter, voldemortCharacter, HarryPotterCharacter.CheckItem())
                        }
                        break;
                }
            
            }
            

        }

        public void WizardFight(HarryPotterCharacter Character, Voldemort voldemort, int damage)
        {
            Character.CheckItem();
            voldemort.TakeDamage(damage);
            Character.TakeDamage(damage);
        }

        public int WizardDamage(int min, int max)
        {
            var random = new Random();
            var damage = random.Next(min, max);
            return damage;
        }

        //public bool CheckItem(HarryPotterCharacter character)
        //{
        //    var item = character.Items.FirstOrDefault(item => item.Name == "Phoenix staff");
        //    if (item.Name == "Phoenix staff")
        //    {
        //        Console.WriteLine($"{character.Name} has an {item.Name}!\n\n" +
        //                          $"Time to fight Voldemort!");
        //        return true;
        //    }
        //    return false;
        //}
    }
}
