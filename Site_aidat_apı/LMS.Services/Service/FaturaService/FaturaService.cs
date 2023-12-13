using LMS.Data.Entities;
using LMS.Data.Repositories.Fatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Services.Service.FaturaService
{
    public class FaturaService : IFaturaSerive
    {
        readonly private IFatruraRepositories _repository;

        public FaturaService(IFatruraRepositories repository)
        {
            _repository = repository;
        }

        public async Task<Fatura> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<Fatura> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Fatura>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Fatura> GetByIdAsync(int id)
        {
           return await _repository.GetByIdAsync(id);
        }

        public async Task<Fatura> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Fatura> InsertAsync(Fatura entity)
        {
            return await _repository.InsertAsync(entity);
        }

        public async Task<Fatura> UpdateAsync(Fatura entity)
        {
           return await  _repository.UpdateAsync(entity);
        }
    }
}
