


namespace PrimeDealsRealestat.Repository.Data
{
    public class PaginatedList<T>
    {
        public int PageIndex { get;  set; }
        public int TotalPages { get;  set; }
        public int TotalCount { get;  set; }
        public List<T> Data { get; set; }
        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            TotalCount = count;
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            Data = items;
        }
        public PaginatedList()
        {
            
        }
        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

    }
}
