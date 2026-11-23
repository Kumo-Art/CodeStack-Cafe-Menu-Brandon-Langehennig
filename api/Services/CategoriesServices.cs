using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public Task<Categories> AddAsync(Categories categories)
        {
            throw new NotImplementedException();
        }

        public Task<List<Categories>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Categories?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}