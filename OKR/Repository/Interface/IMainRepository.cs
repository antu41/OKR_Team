using System.Linq.Expressions;

namespace OKR.Repository.Interface
{
    public interface IMainRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetBySingleAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T item);
        Task UpdateAsync(T item);
        Task DeleteAsync(Expression<Func<T, bool>> predicate);
        Task SaveAsync();
        //IEnumerable<T> GetFiltered(Func<T, bool> predicate);
    }
}
