namespace NetCoreProject.Domain.Interfaces
{
    using System.Linq;
    using System.Threading.Tasks;

    public interface IBaseRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> CreateAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        void RemoveAsync(TEntity entity);
    }
}
