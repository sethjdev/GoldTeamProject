using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoldTeamProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public bool Availability { get; set; }
        public string Category { get; set; }

        //public int UserID { get; set; }
        //public virtual User User { get; set; }

    }
}