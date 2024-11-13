using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using PrimeDealsRealestat.Repository.Data;
using PrimeDealsRealestat.Repository.Interfaces;
using Shiping.Repository.Models;
using System.Linq.Expressions;

namespace PrimeDealsRealestat.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseModel
    {
        private readonly DataContext _context;

        public GenericRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<T> Add(T entity)
        {
            try
            {
                await _context.Set<T>().AddAsync(entity);
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} Couldn't be Added : {ex.Message}");
            }

        }

        public async Task<List<T>> GetAll()
        {
            try
            {
                return await _context.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't Retrieve Data:{ex.Message}");
            }
        }

        public async Task<T> GetById(int id)
        {
            try
            {
                return await _context.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't Retrieve Data:{ex.Message}");
            }
        }

        public async Task<IQueryable<T>> FindByCondition(Expression<Func<T, bool>> expression = null,
                                                        Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            try
            {
                IQueryable<T> query = _context.Set<T>();

                if (expression != null)
                    query = query.Where(expression);
                if (include != null)
                    query = include(query);

                return query;
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't Retrieve Data:{ex.Message}");
            }
        }

        public void Update(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't Retrieve Data:{ex.Message}");
            }
        }

        public async Task<PaginatedList<T>> GetByFilterWithPagination(Expression<Func<T, bool>> filter, int pageNumber, int pageSize, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            try
            {
                IQueryable<T> query = _context.Set<T>();

                if (filter != null)
                {
                    query = query.Where(filter);
                }
                if (include != null)
                    query = include(query);
                query = query.OrderByDescending(w=>w.Id);
                var count = await query.CountAsync();
                var items = await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

                return new PaginatedList<T>(items, count, pageNumber, pageSize);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't Retrieve Data:{ex.Message}");
            }
        }

    }
}
