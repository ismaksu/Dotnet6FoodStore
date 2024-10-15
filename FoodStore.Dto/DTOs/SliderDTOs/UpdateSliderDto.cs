using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.Dto.DTOs.SliderDTOs
{
    public class UpdateSliderDto
    {
        public int SliderId { get; set; }
        public string SliderTitle { get; set; }
        public string ImageUrl { get; set; }
        public string SliderUrl { get; set; }
    }
}
