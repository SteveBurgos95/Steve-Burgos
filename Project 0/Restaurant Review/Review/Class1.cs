using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModel;
using RestaurantModel;

namespace Review
{
    public class Review
    {
        public User? User { get; set; }
        public Restaurant? Restaurant { get; set; }
        public int? Rating { get; set; }
        public string? TimeStamp { get; set; }

        public Review(User user, Restaurant restaurant, int rating)
        {
            User = user;
            Restaurant = restaurant;
            Rating = rating;
        }

    }


}
