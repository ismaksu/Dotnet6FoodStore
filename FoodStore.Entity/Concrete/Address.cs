﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.Entity.Concrete
{
    public class Address
    {
        public int AddressId { get; set; }
        public string AddressDetails { get; set; }
        public string PhoneNumber { get; set; }
        public string Email {  get; set; }
        public string Description { get; set; }
    }
}
