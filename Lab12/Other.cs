using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Other : Player
    {
        public Other(RPSGenerator r) : base(r)
        {
            name = "Others";
        }

        

        public override string GenerateRPS()
        {
            var randomRPS = RandomRPS();
            return randomRPS;
        }
        
    }
}
