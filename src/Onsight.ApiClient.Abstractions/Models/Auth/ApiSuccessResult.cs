using System.Collections.Generic;

namespace Onsight.ApiClient.Abstractions.Models.Auth
{
    public class ApiSuccessResult<T>
    {
        public ApiSuccessResult(long totalCount, long totalPage, ICollection<Link> links, IList<T> results)
        {
            TotalCount = totalCount;
            TotalPage = totalPage;
            Links = links;
            Results = results;
        }

        public long TotalCount { get; }
        public long TotalPage { get; }
        public ICollection<Link> Links { get; }
        public IList<T> Results { get; }
    }
}