using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Console 
    {
        public string GetUserName()
        {
            System.Console.WriteLine("WELCOME TO ROCK PAPER SCISSORS!");
            System.Console.WriteLine("Enter your Name: ");

            var userName = System.Console.ReadLine();
            bool valstatus1= Validation.StringValidation(userName);
            if (valstatus1 == true)
            {
                return userName;
            }
            return "-1";
        }

        public string GetPlayer()
        {
            System.Console.WriteLine("Would you like to play against 'Rocky' or 'Others'? (r/o)");
            var userGetPlayer = System.Console.ReadLine();
           
            return userGetPlayer;
        }

        public string GetRPSfromUser()
        {
            System.Console.WriteLine("Pick your choice! Rock, Paper, Scissors? (r/p/s): ");
            var userRPSresponse = System.Console.ReadLine().ToLower();
            return userRPSresponse;
        }

        
    }
}
