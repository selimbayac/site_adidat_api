using LMS.Data.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly LMSDBContext _context;
        private DbSet<T> _dbSet;
   
        public GenericRepository(LMSDBContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T> DeleteAsync(int id)
        {
           var entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public  async Task<T> DeleteAsync(Guid id)
        {
            var entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var all = await _dbSet.ToListAsync();
            return all;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            return entity;
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            var entity = await _dbSet.FindAsync(id);
            return entity;
        }

        public async Task<T> InsertAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> LoadAsync(string username, string password)
        {
            await _dbSet.LoadAsync(); // Bu satırda LoadAsync metodunu çağıran _dbSet nesnesinin de LoadAsync metodunu tanımlaması gerekiyor
            await _context.SaveChangesAsync();
            return await _dbSet.FirstOrDefaultAsync();


            //var user = await _dbSet.FindAsync(username, password); // Bu satırda _dbSet nesnesinin FindAsync metodunu tanımlaması gerekiyor
            //if (user == null)
            //{
            //    return null; // Bu satırda kullanıcı bulunamazsa null değer döndürüyoruz
            //}
            //return user;

        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
