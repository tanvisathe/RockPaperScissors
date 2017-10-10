using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Score
    {
        public int winCountUser = 0;
        public int winCountRocky = 0;
        public int winCountOthers = 0;
        int[] scoreBoard = new int[3];

        public Score()
        {

        }
        public int[] ScoreCard(string _rocky, string _other, string _human, string _userName, string _playerName)
        {
            RPSGenerator rps = new RPSGenerator();
            Rocky ro = new Rocky(rps);
            Other ot = new Other(rps);

            if (_playerName == "r")
            {
                //Draw
                if (_human == _rocky)
                {
                    System.Console.WriteLine("Draw!");
                }
                //Paper beats rock
                else if (_human == "paper")
                {
                    winCountUser++;
                    System.Console.WriteLine(_userName + " :wins!"); // user wins
                }
                //Rock beats scissors
                else if (_human == "scissors")
                {
                    winCountRocky++;
                    System.Console.WriteLine(ro.GetName() + " :wins!"); // rocky wins
                }

            }

            if (_playerName == "o")
            {
                //Draw
                if (_human == _other)
                {
                    System.Console.WriteLine("Draw!");
                }
                //paper beats rock
                else if (_human == "paper" && _other == "rock")
                {
                    winCountUser++;
                    System.Console.WriteLine(_userName + " :wins!");// user wins
                }
                else if (_human == "rock" && _other == "paper")
                {
                    winCountOthers++;
                    System.Console.WriteLine(ot.GetName() + " :wins!");//others win
                }
                //rock beats scissors
                else if (_human == "rock" && _other == "scissors")
                {
                    winCountUser++;
                    System.Console.WriteLine(_userName + " :wins!"); // user wins
                }
                else if (_human == "scissors" && _other == "rock")
                {
                    winCountOthers++;
                    System.Console.WriteLine(ot.GetName() + " :wins!");//other wins
                }
                //scissors beat paper
                else if (_human == "scissors" && _other == "paper")
                {
                    winCountUser++;
                    System.Console.WriteLine(_userName + " :wins!");//user wins
                }
                else if (_human == "paper" && _other == "scissors")
                {
                    winCountOthers++;
                    System.Console.WriteLine(ot.GetName() + " :wins!");//other wins
                }
            }
            scoreBoard[0] = winCountUser;
            scoreBoard[1] = winCountRocky;
            scoreBoard[2] = winCountOthers;
            return scoreBoard;
        }

        public static void DisplayScore(int[] _track, string _username)
        {
            System.Console.WriteLine();
            System.Console.WriteLine(_username + " wins: " + _track[0]);
            System.Console.WriteLine("Rocky wins: " + _track[1]);
            System.Console.WriteLine("Others win: " + _track[2]);
        }
    }
}
