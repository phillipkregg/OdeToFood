using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
      
    }
}