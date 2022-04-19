using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RestaurantModel
{
    public class Restaurant
    {
        
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public string? PhoneNumber { get; set; }
        public string[]? Menu { get; set; }

        internal Restaurant(string name, string address, string phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }
        internal Restaurant(string name, string address, string phoneNumber, string email)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        internal Restaurant(string name, string address, string phoneNumber, string email, string website)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            Website = website;
        }


    }


    public class RestaurantOwner
    {
        internal string? Firstname { get; set; }
        internal string? Lastname { get; set; }
        internal string? Email { get; set; }
        internal string? PhoneNumber { get; set; }
        internal Restaurant? Restaurant { get; set; }

        internal RestaurantOwner(string firstName, string lastName, string email, string phoneNumber, Restaurant restaurant)
        {

        }


    }
    
   
}
