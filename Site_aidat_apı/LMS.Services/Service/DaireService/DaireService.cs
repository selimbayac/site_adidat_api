using LMS.Data.Entities;
using LMS.Data.Repositories.Daire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Services.Service.DaireService
{
    public class DaireService : IDaireService
    {
       private readonly IDaireRepositories _daireService;

        public DaireService(IDaireRepositories daireService)
        {
            _daireService = daireService;
        }

        public async Task<Daire> DeleteAsync(int id)
        {
           return await _daireService.DeleteAsync(id);
        }

        public Task<Daire> DeleteAsync(Guid id)
        {
            return Task.FromResult<Daire>(null);
        }

        public async Task<IEnumerable<Daire>> GetAllAsync()
        {
           return await _daireService.GetAllAsync();
        }

        public async Task<Daire> GetByIdAsync(int id)
        {
            return await _daireService.GetByIdAsync(id);
        }

        public Task<Daire> GetByIdAsync(Guid id)
        {
            return Task.FromResult<Daire>(null);
        }

        public async Task<Daire> InsertAsync(Daire entity)
        {
            return await _daireService.InsertAsync(entity);
        }

        public async Task<Daire> UpdateAsync(Daire entity)
        {
            return await _daireService.UpdateAsync(entity);
        }
    }
}
