﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Datas.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public CuisineType Cuisine { get; set; }
        
        public string ImageUrl { get; set; }

        public string Description { get; set; }
    }
}
