﻿using System;
using System.Collections.Generic;

namespace RestAPI.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Product> Products { get; set; } 
    }
}
