namespace NetCoreProject.Domain.Result
{
    using System.Collections.Generic;

    public class CollectionResult<T> : BaseResult<IEnumerable<T>>
    {
        public int Count { get; set; }
    }
}
