using Microsoft.EntityFrameworkCore;
using OKR.Data;
using OKR.Repository.Interface;
using System.Linq.Expressions;

namespace OKR.Repository.Implement
{
    public class MainRepository<T> : IMainRepository<T> where T : class
    {
        protected readonly ApplicationDbContext db;

        public MainRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task AddAsync(T item)
        {
            await db.Set<T>().AddAsync(item);
        }

        public async Task DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            var item = await db.Set<T>().SingleOrDefaultAsync(predicate);
            if (item != null)
            {
                db.Set<T>().Remove(item);
            }
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await db.Set<T>().ToListAsync();
        }

        public async Task<T> GetBySingleAsync(Expression<Func<T, bool>> predicate)
        {
            return await db.Set<T>().SingleOrDefaultAsync(predicate);
        }

        public async Task SaveAsync()
        {
            await db.SaveChangesAsync();
        }

        public async Task UpdateAsync(T item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        //public async Task<T> GetFiltered(Expression<Func<T, bool>> predicate
        //{
        //    return await db.Set<T>().Where(predicate);
        //}
    }
}
