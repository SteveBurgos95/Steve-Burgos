using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModels
{
    public class RestaurantModel
    {
        public int RestaurantID { get; set; }
        public string? RestaurantName { get; set; }
        public string? RestauranAddress { get; set; }
        public string? RestaurantCity { get; set; }
        public string? Restaurantstate { get; set; }
        public string? RestaurantZipCode { get; set; }
        public string? RestaurantCountry { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }

    }
}
