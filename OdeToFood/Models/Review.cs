using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class Review
    {
        
        public virtual int ID { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual int Rating { get; set; }
        public virtual string Body { get; set; }
        public virtual DateTime Created { get; set; }
    }
}