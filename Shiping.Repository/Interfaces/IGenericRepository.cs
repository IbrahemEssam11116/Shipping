using Microsoft.EntityFrameworkCore.Query;
using PrimeDealsRealestat.Repository.Data;
using Shiping.Repository.Models;
using System.Linq.Expressions;

namespace PrimeDealsRealestat.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : BaseModel
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Add(T entity);
        void Update(T entity);
        Task<IQueryable<T>> FindByCondition(Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<PaginatedList<T>> GetByFilterWithPagination(Expression<Func<T, bool>> filter, int pageNumber, int pageSize, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
    }
}
