﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoldTeamProject.Models
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Photo { get; set; }
    }
}