using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI
{
    class AdminView : UIMenus
    {
        public void Display()
        {
            Console.WriteLine("Enter Back for Main Menu or");
            Console.WriteLine("type in the first name of the user you would like to search");
    

        }

        public string UserChoice()
        {
            // Console.ReadLine returns null if redirecting from a file and the file ends
            if (Console.ReadLine() is not string userInput)
                throw new InvalidDataException("end of input");

            switch (userInput)
            {
                case "Back":
          
                    return "MainMenu";
                case "1":
           
                    return "Userview";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    return "AdminView";
            }
        }
    }
}
