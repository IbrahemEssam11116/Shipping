using PrimeDealsRealestat.Repository.Data;
using PrimeDealsRealestat.Repository.Interfaces;

namespace PrimeDealsRealestat.Repository
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> Save()
        {
            try
            {
                var isSaved = await _context.SaveChangesAsync() > 0;
                return isSaved;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }

        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

