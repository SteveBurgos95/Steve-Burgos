using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantDL;
using RestaurantModels;


namespace RestaurantUI
{


    class AddReviewView : UIMenus
    {
        static readonly ReviewModel newReview = new();
        
        readonly IRepository repository;

        public AddReviewView(IRepository repository)
        {
            this.repository = repository;
        }


        public void Display()
        {
            Console.WriteLine("Enter Restaurant ID: " + newReview.ReviewID);
            Console.WriteLine("Enter your User ID: " + newReview.UserId);
            Console.WriteLine("Enter a score from 1-10: " + newReview.ReviewScore);
            Console.WriteLine("Enter <0> for main menu");


        }


        public string UserChoice()
        {
            return "UserView";
        }
    }
}

