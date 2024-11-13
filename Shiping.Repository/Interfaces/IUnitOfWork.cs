namespace PrimeDealsRealestat.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> Save();

    }
}
