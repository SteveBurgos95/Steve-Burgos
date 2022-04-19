using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantModel;

namespace UserModel
{
    public class User
    {

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public User(string firstName, string lastName, string email)
        {
            Firstname = firstName;
            Lastname = lastName;
            Email = email;
        }

        public void createReview()
        {

        }
        public void displayDetails()
        {

        }
        public void displayReviews()
        {

        }
        public void searchRestaurant()
        {

        }


    }

    public class Admin : User
    {
        public Admin(string firstName, string lastName, string email) : base(firstName, lastName, email)
        {
            Firstname = firstName;
            Lastname = lastName;
            Email = email;
        }
        public void searchUser()
        {

        }



        

    }

    public class Customer : User
    {
        public Customer(string firstName, string lastName, string email) : base(firstName, lastName, email)
        {
            Firstname = firstName;
            Lastname = lastName;
            Email = email;
        }
    }

}
