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
            
            return items.ToList();
        }

        public async Task<Items?> GetByIdAsync(int id)
        {
            Items? item = await _repository.GetByIdAsync(id);

            if(item is null)
            {
                return null;
            }

            return item;
        }

        public async Task<Items?> UpdateAsync(int id, Items items)
        {
            Items? item = await _repository.GetByIdAsync(id);

            if(item is null)
            {
                return null;
            }

            item.Category = items.Category;
            item.Description = items.Description;
            item.Id = items.Id;
            item.Name = items.Name;
            item.Price = items.Price;
            item.Tag = items.Tag;
            item.Image = items.Image;

            await _repository.UpdateAsync(item);

            return item;
        }
    }
}