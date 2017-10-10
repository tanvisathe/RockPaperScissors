using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Validation
    {
        public static bool StringValidation(string _userName)
        {          
            try
            {             
                if (string.IsNullOrWhiteSpace(_userName) || string.IsNullOrWhiteSpace(_userName))
                {
                    System.Console.WriteLine("Please enter valid input and try again.");
                    
                    return false;
                }              
                else
                {
                    return true;
                }
            }

            catch (Exception ex)
            {
                System.Console.WriteLine($"{ex.GetType() }  means  {ex.Message}");
                return false;
            }
        }


        public static bool StringValidationRO(string _userGetPlayer)
        {
            try
            {
                StringValidation(_userGetPlayer);
                
                if(_userGetPlayer !="r" || _userGetPlayer !="R" || _userGetPlayer !="o" || _userGetPlayer != "O")
                {
                    System.Console.WriteLine("Please make a valid choice (r/o)");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            catch (Exception ex)
            {
                System.Console.WriteLine($"{ex.GetType() }  means  {ex.Message}");
                return false;

            }

        }

        public static bool StringValidationRPS(string _userRPSresponse)
        {
            try
            {
                StringValidation(_userRPSresponse);
                
                if (_userRPSresponse != "r" || _userRPSresponse != "p" || _userRPSresponse != "s" )
                {
                    System.Console.WriteLine("Please make a valid choice (r/p/s)");
                    
                    return false;
                    
                }
                else
                {
                    return true;
                }
            }

            catch (Exception ex)
            {
                System.Console.WriteLine($"{ex.GetType() }  means  {ex.Message}");
                return false;

            }

        }
    }
}
