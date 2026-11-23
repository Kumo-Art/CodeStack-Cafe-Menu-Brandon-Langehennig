using api.Data;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class CategoriesRepository : ICategoriesRepository
    {

        private readonly AppDbContext _db;

        public CategoriesRepository(AppDbContext db)
        {
            _db = db;
        }
        public async Task<Categories> AddAsync(Categories categories)
        {
           _db.Categories.Add(categories);

           await _db.SaveChangesAsync();

           return categories;
        }

        public async Task<List<Categories>> GetAllAsync()
        {
             return await _db.Categories.ToListAsync();
        }

        public async Task<Categories?> GetByIdAsync(int id)
        {
            return await _db.Categories.FindAsync(id);
        }
    }
}