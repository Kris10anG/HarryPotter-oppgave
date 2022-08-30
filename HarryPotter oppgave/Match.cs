using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter_oppgave
{
    internal class Match
    {
        public QuidditchTeam Hjemmelag { get; private set; }
        public QuidditchTeam Bortelag { get; private set; }
        public Match()
        {
           Hjemmelag = new QuidditchTeam("Hjemmelag");
           Bortelag = new QuidditchTeam("Bortelag");
            //Hjemmelag = new List<HarryPotterCharacter>
            //{
            //    new HarryPotterCharacter("Terje", 100, 20, "Gryffindor", 100, true, "Chaser"),
            //    new HarryPotterCharacter("Geir", 100, 20, "Gryffindor", 100, true, "Chaser"),
            //    new HarryPotterCharacter("Eskil", 100, 20, "Gryffindor", 100, true, "Chaser"),
            //    new HarryPotterCharacter("Thorbjørn", 100, 20, "Gryffindor", 100, true, "beater"),
            //    new HarryPotterCharacter("Tommy", 100, 20, "Gryffindor", 100, true, "beater"),
            //    new HarryPotterCharacter("Mats", 100, 20, "Gryffindor", 100, true, "keeper"),
            //};
            //Bortelag = new List<HarryPotterCharacter>
            //{
            //    new HarryPotterCharacter("Edgar", 100, 20, "Gryffindor", 100, true, "Chaser"),
            //    new HarryPotterCharacter("Peder", 100, 20, "Gryffindor", 100, true, "Chaser"),
            //    new HarryPotterCharacter("Johan", 100, 20, "Gryffindor", 100, true, "Chaser"),
            //    new HarryPotterCharacter("Lasse", 100, 20, "Gryffindor", 100, true, "beater"),
            //    new HarryPotterCharacter("Tom", 100, 20, "Gryffindor", 100, true, "beater"),
            //    new HarryPotterCharacter("Mohammed", 100, 20, "Gryffindor", 100, true, "keeper"),
            //};
            while (!Hjemmelag.WonMatch() && !Bortelag.WonMatch())
            {
                Hjemmelag.TryToCatchSnitch(IsSuccessful(10));
                // try to catch snich øker score med 100 og laget vinner umiddelbart
                Bortelag.TryToCatchSnitch(IsSuccessful(10));

                Hjemmelag.TryToScoreGoal(IsSuccessful(5));
                // øker lagets goals med 1, 3 eller 5 poeng
                Bortelag.TryToScoreGoal(IsSuccessful(5));

                PrintScore(Hjemmelag, Bortelag); //printer ut dersom noen har scored goal
            }
        }

        //public Match()
        //{
        //}

        //public Match(QuidditchTeam team1, QuidditchTeam team2)
        //  {
        //      while (!team1.WonMatch() && !team2.WonMatch())
        //      {
        //          team1.TryToCatchSnitch(IsSuccessful(10));
        //          // try to catch snich øker score med 100 og laget vinner umiddelbart
        //          team2.TryToCatchSnitch(IsSuccessful(10));

        //          team1.TryToScoreGoal(IsSuccessful(5));
        //          // øker lagets goals med 1, 3 eller 5 poeng
        //          team2.TryToScoreGoal(IsSuccessful(5));

        //          PrintScore(team1, team2); //printer ut dersom noen har scored goal
        //      }
        //  }



        public static void PrintScore(QuidditchTeam team1, QuidditchTeam team2)
        {
            if (team1.Score >= 1)
            {
                Console.WriteLine($"Sålangt er stillingen til team1: {team1.Score}");
            }

            if (team2.Score >= 1)
            {
                Console.WriteLine($"Sålangt er stillingen til team1: {team2.Score}");

            }
          
        }

        public static bool IsSuccessful(int maxValue)
        {
            Random rand = new Random();
            return rand.Next(0, maxValue) == 2;
        }
    }
}
