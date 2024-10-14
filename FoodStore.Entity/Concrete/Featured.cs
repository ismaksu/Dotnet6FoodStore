using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.Entity.Concrete
{
    public class Featured
    {
        public int FeaturedId { get; set; }
        public string FeaturedTitle { get; set; }
        public string FeaturedDescription { get; set; }
        public bool FeaturedStatus {  get; set; }
    }
}
