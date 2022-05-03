using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI
{
    class NewUser : UIMenus
    {
        public void Display()
        {
            Console.Write("Please Enter your desired login email: ");
            string? email = Console.ReadLine();
            Console.Write("Please Enter your desired login password: ");
            string? password = Console.ReadLine();
            Console.Write("Please Enter your First Name: ");
            string? firstName = Console.ReadLine();
            Console.Write("Please Enter your Last Name: ");
            string? lastName = Console.ReadLine();
            Console.Write("Please Enter your phone number: ");
            string? phoneNumber = Console.ReadLine();
            Console.Write("Press <0> to continue to LoginMenu: ");
           // string? newUserInput = Console.ReadLine();

        }

        public string UserChoice()
        {
            // Console.ReadLine returns null if redirecting from a file and the file ends
        
            if (Console.ReadLine() is not string newUserInput)
                throw new InvalidDataException("end of input");

            while(newUserInput != "0")
            {
                Console.WriteLine("Press <0> to continue to LoginMenu");
                newUserInput = Console.ReadLine();
            }

            return "LoginMenu";
         
        }
    }
}
