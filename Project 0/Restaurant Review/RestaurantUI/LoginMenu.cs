using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RestaurantUI
{
    class LoginMenu: UIMenus
    {
        public void Display()
        {
            Console.WriteLine("Welcome to the Restaurant Review App");
            Console.WriteLine("Press <0> for Login");
            Console.WriteLine("Press <1> for New User");

        }

        public string UserChoice()
        {
            // Console.ReadLine returns null if redirecting from a file and the file ends
            if (Console.ReadLine() is not string userInput)
                throw new InvalidDataException("end of input");

            switch (userInput)
            {
                case "0":

                    return "Login";
                case "1":
                    return "NewUser";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    return "LoginMenu";
            }
        }
    }
}
