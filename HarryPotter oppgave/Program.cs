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
            var harryPotterCharacter = new HarryPotterCharacter("Kris10an", 200, 0, "Gryffindor", 100, true, "seeker");
            var voldemortCharacter = new Voldemort($"Voldemort", 100, true);
            
            var magicstore = new MagicStore();

            


            //var question = Console.ReadLine();
            while (true)
            {
                Console.WriteLine($"Hello {harryPotterCharacter.Name}! Write stats to see your stats," +
                                  $" store for going to the Magic store, money for making some wizardmoney" +
                                  $", magic for some epic magic!, " +
                                  $"letter to send a letter" +
                                  $"exit for exit!");
                var command = Console.ReadLine();

            switch (command)
                {
                                

                    case "stats":
                        harryPotterCharacter.ShowInformation();

                        Console.WriteLine($"Name: {harryPotterCharacter.Name}\n House: {harryPotterCharacter.House}\n" +
                        $"WizardMoney {harryPotterCharacter.Money}\n");
                        
                        break;

                    case "store":
                    {
                        Console.WriteLine($"What magicitems are you looking for?\n" +
                                          $"(type Wand, broom or Pet?)");
                        var whitchShop = Console.ReadLine();
                        magicstore.ShowPetsAndWands(whitchShop);
                        
                        Console.WriteLine($"What do you want to buy?");
                        var question = Console.ReadLine();

                        magicstore.SellMagicalItems(question, harryPotterCharacter, whitchShop);
                        break;
                    }
                    case "money":
                        var mathQuestion = Console.ReadLine();

                        var magicalNumber = Convert.ToInt32(mathQuestion);
                        
                        var mathSpell = harryPotterCharacter.DoMathMagic(magicalNumber);
                        Console.WriteLine(mathSpell);
                        break;
                    case "magic":
                        Console.WriteLine($"Kom igjen {harryPotterCharacter.Name}!" +
                                          $"Bruk dine magiske trylleevner og få fjærden til å sveve...\n" +
                                          $"Hint (vingardium leviosa)");

                        var spellQuestion = Console.ReadLine();

                        harryPotterCharacter.MakeFeatherFly(spellQuestion);
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    case "letter":
                        Console.WriteLine($"Hva vil du skrive til Voldemort!");
                        var message = Console.ReadLine();
                        var letter = new Letter(message);
                        harryPotterCharacter.SendLetterWithOwl(letter, voldemortCharacter);
                        break;
                    case "voldemort":
                        voldemortCharacter.ShowInventory();
                        break;
                    case "battle":
                        while (harryPotterCharacter.IsAlive && voldemortCharacter.IsAlive)
                        {
                            WizardFight(harryPotterCharacter, voldemortCharacter);
                        }
                        break;
                    case "quidditch":
                        var match = new Match();
                        break;
                }
            
            }
            

        }

        public static void WizardFight(HarryPotterCharacter character, Voldemort voldemort)
        {
            
            voldemort.DealDamageTo(character);
            character.CheckDeath();
            if (!character.IsAlive)
            {
              return;  
            }
            character.DealDamage(voldemort);
            voldemort.CheckDeath();

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
