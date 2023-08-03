using HumanResources.Domain.Absract;
using System.Linq.Expressions;

namespace HumanResources.Domain.Repostories
{
    public interface IRepostories<T> where T :BasePersonel
    {
        Task<IQueryable<T>> GetAllAsync();
        Task<IQueryable<T>> GetByFilterAsync(Expression<Func<T, bool>> filter);
        Task<bool> AnyAsync(Expression<Func<T, bool>> filter);
        Task<T> GetById(object PersonelId);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
        Task<T> Delete(object PersonelId);
    }
   
}
