using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    abstract class Player
    {
        protected string name;
        protected RPSGenerator rpsList;

        public Player(RPSGenerator r)
        {
            rpsList = r;
        }

        public string GetName()
        {
            return name;
        }

        public abstract string GenerateRPS();
        
        //Below Method randomly generates Rock, Paper and Scissors for Other class
        public string RandomRPS()
        {
            Random rand = new Random();
            int min = 0;
            int max = 3;
            var randomNumber = rand.Next(min, max);
            var listIndex = rpsList.GetByIndex(randomNumber);
            return listIndex;
        }

        
    }
}
