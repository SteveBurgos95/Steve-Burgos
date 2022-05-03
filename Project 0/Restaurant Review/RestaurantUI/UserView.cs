using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI
{
    class UserView: UIMenus
    {
        public void Display()
        {
            Console.WriteLine("Enter Back for Main Menu or");
            Console.WriteLine("Press <0> for Restaurant Information");
            Console.WriteLine("Press <1> Add a new review");
 


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
                case "0":
                    return "Userview";
                case "1":
                    return "AddReview";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    return "AdminView";
            }
        }
    }
}
