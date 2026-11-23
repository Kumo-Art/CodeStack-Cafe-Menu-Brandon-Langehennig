using api.Models;

namespace api.Repository
{
    public interface IItemsRepository
    {
        Task<List<Items>> GetAllAsync();

        Task<Items?> GetByIdAsync(int id);

        Task<Items> AddAsync(Items items);

        Task UpdateAsync(Items item);
    }
}