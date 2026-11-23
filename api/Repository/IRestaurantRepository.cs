using api.Models;

namespace api.Repository
{
    public interface IRestaurantRepository
    {
        Task<Restaurant?> GetByIdAsync(int id);

        Task<Restaurant> AddAsync(Restaurant restaurant);
    }
}