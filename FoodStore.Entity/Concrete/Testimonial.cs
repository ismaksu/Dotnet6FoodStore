using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.Entity.Concrete
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerTitle { get; set; }
        public string CustomerComment { get; set; }
        public string ImageUrl { get; set; }
    }
}
