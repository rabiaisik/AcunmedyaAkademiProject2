﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunmedyaAkademi2.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }

        public int? CategoryId {  get; set; }

        public virtual Category Category { get; set; }
    }
}