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

        public Task<Restaurant> AddAsync(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public Task<Restaurant?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}