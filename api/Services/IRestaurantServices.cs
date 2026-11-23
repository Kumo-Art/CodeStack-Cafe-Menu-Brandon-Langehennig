
using api.Models;

namespace api.Services
{
    public interface IRestaurantServices
    {
        Task<Restaurant?> GetByIdAsync(int id);

         Task<Restaurant> AddAsync(Restaurant restaurant);
    }
}