using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public Task<Items> AddAsync(Items items)
        {
            throw new NotImplementedException();
        }

        public Task<List<Items>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Items?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}