using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            RPSGenerator rps = new RPSGenerator();
            Rocky r = new Rocky(rps);
            var rocky = r.GenerateRPS();
            Other o = new Other(rps);
            var other = o.GenerateRPS();
            Console c = new Console();
            Score sc = new Score();
            int[] track = new int[2];

            var userName = c.GetUserName();
           
            bool run = true;
            while (run == true)
            {
                var playerName = c.GetPlayer();//Rocky or Others
                var userChoiceRPS = c.GetRPSfromUser();//r/p/s 

                var human = rps.GetByString(userChoiceRPS.ToLower());  // Compares user string against the list (r/p/s) stored in RPSGenerator class

                if (playerName == "r")
                {
                    System.Console.WriteLine("Rocky: " + rocky); // rocky
                }
                else if (playerName == "o")
                {
                    System.Console.WriteLine("Other: " + other); // other
                }
                else
                {
                    System.Console.WriteLine("I did not understand that, please try again.");
                }

                System.Console.WriteLine(userName + " : " + human); // user player

                track = sc.ScoreCard(rocky, other, human, userName, playerName);//integer array "track" keeps scores
                run = Continue();
            }
            Score.DisplayScore(track, userName);

        }

        public static bool Continue()
        {
            System.Console.WriteLine("Play again?(y/n)");
            string input = System.Console.ReadLine();
            input = input.ToLower();
            bool goAhead;
            if (input == "y")
            {
                goAhead = true;

            }
            else if (input == "n")
            {
                System.Console.WriteLine("Good Bye!");
                goAhead = false;
            }
            else
            {
                System.Console.WriteLine("I don't understand that, please try again");
                goAhead = Continue();
            }
            return goAhead;
        }
    }
}
