
using api.Models;
using api.Repository;

namespace api.Services
{
    public class CategoriesServices : ICategoriesServices
    {
        private readonly ICategoriesRepository _repository;

        public CategoriesServices(ICategoriesRepository repository)
        {
            _repository = repository;
        }

        public async Task<Categories> AddAsync(Categories categories)
        {
            Categories category = new Categories();
            category.Id = categories.Id;
            category.Name = categories.Name;

            return await _repository.AddAsync(category);
        }

        public async Task<List<Categories>> GetAllAsync()
        {
             List<Categories> category = await _repository.GetAllAsync();

             return category.ToList();
        }

        public async Task<Categories?> GetByIdAsync(int id)
        {
            Categories? category = await _repository.GetByIdAsync(id);

            if(category is null)
            {
                return null;
            }

            return category;
        }
    }
}