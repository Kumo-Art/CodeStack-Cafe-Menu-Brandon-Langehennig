using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Services
{
    public interface IItemsServices
    {
        Task<List<Items>> GetAllAsync();

        Task<Items?> GetByIdAsync(int id);

        Task<Items> AddAsync(Items items);
    }
}