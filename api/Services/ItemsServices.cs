using api.Models;
using api.Repository;

namespace api.Services
{
    public class ItemsServices : IItemsServices
    {
        private readonly IItemsRepository _repository;

        public ItemsServices(IItemsRepository repository)
        {
            _repository = repository;
        }

        public async Task<Items> AddAsync(Items items)
        {
            Items item = new Items();
            item.Name = items.Name;
            item.Category = items.Category;
            item.Description = items.Description;
            item.Image = items.Image;
            item.Price = items.Price;
            item.Tag = items.Tag;

            return await _repository.AddAsync(item);

        }

        public async Task<List<Items>> GetAllAsync()
        {
            List<Items> items = await _repository.GetAllAsync();
            //start here
        }

        public Task<Items?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}