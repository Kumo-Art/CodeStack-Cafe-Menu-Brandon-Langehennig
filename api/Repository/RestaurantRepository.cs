using api.Data;
using api.Models;

namespace api.Repository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly AppDbContext _db;

        public RestaurantRepository(AppDbContext db)
        {
            _db = db;
        } 
        public async Task<Restaurant> AddAsync(Restaurant restaurant)
        {
            _db.Restaurant.Add(restaurant);

            await _db.SaveChangesAsync();

            return restaurant;
        }

        public async Task<Restaurant?> GetByIdAsync(int id)
        {
            return await _db.Restaurant.FindAsync(id);
        }
    }
}