 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Rocky : Player
    {
        public Rocky(RPSGenerator r) : base(r)
        {
            name = "Rocky";
        }
       

        public override string GenerateRPS()
        {
            return rpsList.GetByIndex(0);           
        }
    }
}
