
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantModels;
using RestaurantDL;

namespace RestaurantBL
{
    public class Restaurant : IRestaurant
    {
        readonly IRepository repository;
        public Restaurant(IRepository repository)
        {
            this.repository = repository;
        }
        ReviewModel AverageRestaurants(ReviewModel r)
        {
            return r;
        }
        RestaurantModel DisplayDetails(RestaurantModel r)
        {
            return r;
        }

        ReviewModel AddReview(ReviewModel r)
        {
            return r;
        }


        List<UserModel> SearchUserModel(string n)
        {
            List<UserModel> john = null;
            return john;
        }

        
    }
}
