using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data
{
    public class RestaurantDataSql : IRestaurantData
    {
        private readonly OdeToFoodDbContext odeToFoodDbContext;
        public RestaurantDataSql(OdeToFoodDbContext odeToFoodDbContext)
        {
            this.odeToFoodDbContext = odeToFoodDbContext;
        }

        public Restaurant GetRestaurantById(int restaurantId)
        {
            return odeToFoodDbContext.Restaurants.SingleOrDefault(r => r.Id == restaurantId);
        }

        public IEnumerable<Restaurant> GetRestaurants(string name = null)
        {
            return odeToFoodDbContext.Restaurants.Where(r => string.IsNullOrEmpty(name) || r.Name == name).ToList();
        }
    }
}
