using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using api.Repository;

namespace api.Services
{
    public class RestaurantServices : IRestaurantServices
    {
        private readonly IRestaurantRepository _repository;

        public RestaurantServices(IRestaurantRepository repository)
        {
            _repository = repository;
        }

        public async Task<Restaurant> AddAsync(Restaurant restaurant)
        {
            Restaurant rest = new Restaurant();
            rest.Name = restaurant.Name;
            rest.Adrress = restaurant.Adrress;
            rest.Hours = restaurant.Hours;
            rest.Phone = restaurant.Phone;
            rest.TagLine = restaurant.TagLine;

            return await _repository.AddAsync(rest);
        }

        public async Task<Restaurant?> GetByIdAsync(int id)
        {
            Restaurant? restaurant = await _repository.GetByIdAsync(id);

            if(restaurant is null)
            {
                return null;
            }

            return restaurant;
        }
    }
}