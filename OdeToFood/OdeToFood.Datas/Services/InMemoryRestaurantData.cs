using OdeToFood.Datas.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Datas.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name="Sams Pizza", Cuisine = CuisineType.Italian, ImageUrl = "~/img/France.png", Description = "Sam's Wonderful Italian Pizza Place"},
                new Restaurant {Id = 2, Name="Dan's Pizza", Cuisine = CuisineType.Italian, ImageUrl = "~/img/Pizza.png",  Description = " Dan's Wonderful Italian Pizza Place"},
                new Restaurant {Id = 3, Name="Burrito Loco", Cuisine = CuisineType.Mexican, ImageUrl = "~/img/Mexico.png", Description = "Wonderful Burritos"},
                new Restaurant {Id = 4, Name="Taco Loco", Cuisine = CuisineType.Mexican, ImageUrl = "~/img/Mexico.png",  Description = "Wonderful Tacos"}

            };

             
        }
        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            restaurant.Id = restaurants.Max(r => r.Id) + 1;
        }
        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }

        public void Update(Restaurant restaurant)
        {
            var restToEdit = Get(restaurant.Id);
            if(restToEdit != null)
            {
                restToEdit.Name = restaurant.Name;
                restToEdit.Cuisine = restaurant.Cuisine;
            }
        }
    
    }
}
