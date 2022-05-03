using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RestaurantUI
{
    class Login: UIMenus    
    {
        public void Display()
        {

            Console.Write("Login: ");
            string? login = Console.ReadLine();


            Console.WriteLine("Password");
            string? password = Console.ReadLine();

            Console.Write("Enter <0> for AdminView or <1> for UserView: ");

        }

        public string UserChoice()
        {
            // Console.ReadLine returns null if redirecting from a file and the file ends
            if (Console.ReadLine() is not string userInput)
                throw new InvalidDataException("end of input");

            switch (userInput)
            {
                case "0":

                    return "AdminView";
                case "1":

                    return "UserView";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    return "GoToMainMenu";
            }
        }
    }
}
