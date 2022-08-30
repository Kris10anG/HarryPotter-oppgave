using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter_oppgave
{
    internal class QuidditchTeam
    {
        public string TeamName { get; private set; }
        public int Score { get; private set; }


        public QuidditchTeam(string teamName)
        {
            TeamName = teamName;
        }

        public bool WonMatch()
        {
            //Si ifra om noen har vunnet matchen
            if (Score == 100)
            {
                Console.WriteLine($"The score has reached {Score}! The game is over");
                return true;
            }

            return false;
        }

        public void TryToCatchSnitch(bool isSuccesful)
        {
            if (isSuccesful == true)
            {
                Match team;
                Score = 100;
                Console.WriteLine($"{TeamName} has reached 100 points!!!");
            }
            
        }

        public void TryToScoreGoal(bool isSuccesFull)
        {
            var rand = new Random();
            if (isSuccesFull == true)
            {
               var number = rand.Next(1, 4);
               if (number == 1)
               {
                   Score++;
                   Console.WriteLine($"{TeamName},Score has increassed with 1, score: {Score}");
               }

               if (number == 2)
               {
                   Score += 3;
                   Console.WriteLine($"{TeamName}, Score has increassed with 3, score: {Score}");

                }

                if (number == 3)
               {
                   Score += 5;
                   Console.WriteLine($"{TeamName}, Score has increassed with 5, score: {Score}");

                }
            }
        }

    }
}


//Jeg blir ganske opptatt imorra (tirsdag) så har satt opp liste til ting du kan gjøre:
//1.Fiks sånn at i battle blir karakteren død dersom de har <= 0 i hp
//2. Prøv å få til ugle- delen av oppgaven (klasse Letter med string Message) -character.SendLetterWithOwl(Letter letterToSend)
//3.Ny quidditch del:
//Quidditch

//    Utvid butikken din med brooms:
//Nimbus 2000 - speed 1000
//Firebolt - speed 2000
//Turbo XXX      - speed 500

//Dersom du har kjøpt deg en broom, skal du kunne spille quidditch

//Når du spiller quidditch havner du på lag med 6 andre harry potter characters
//din rolle er “seeker” 

//Lag en klasse som heter QuidditchTeam
//klassen består av en liste med 7 harry potter characters,
//3 av de må være type chaser,
//2 av de må være type beater
//1 keeper
//1 seeker

//    Sett sammen 2 quidditchlag til en Quidditchmatch, hjemmelag og bortelag
//Match(QuidditchTeam team1, QuidditchTeam team2)
//{
//    while (!team1.WonMatch && !team2.WonMatch)
//    {
//        team1.TryToCatchSnitch(IsSuccessful(10));
//        // try to catch snich øker score med 100 og laget vinner umiddelbart
//        team2.TryToCatchSnitch(IsSuccessful(10));

//        team1.TryToScoreGoal(IsSuccessful(5));
//        // øker lagets goals med 1, 3 eller 5 poeng
//        team2.TryToScoreGoal(IsSuccessful(5));

//        PrintScore(team1, team2); //printer ut dersom noen har scored goal
//    }
//}

//public static bool IsSuccessful(int maxValue)
//{
//    Random rand = new Random();
//    return rand.Next(0, maxValue) == 2;
//}