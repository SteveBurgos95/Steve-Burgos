using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModels
{
    public class ReviewModel
    {
        public int ReviewID { get; set; }
        public int RestaurantID { get; set; }
        public int UserId { get; set; }
        public int ReviewScore { get; set; }
    }
}
