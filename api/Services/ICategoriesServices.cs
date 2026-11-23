using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Services
{
    public interface ICategoriesServices
    {
        Task<List<Categories>> GetAllAsync();

        Task<Categories?> GetByIdAsync(int id);

        Task<Categories> AddAsync(Categories categories);
    }
}