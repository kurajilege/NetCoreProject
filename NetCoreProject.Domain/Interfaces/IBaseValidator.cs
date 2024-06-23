namespace NetCoreProject.Domain.Interfaces
{
    using NetCoreProject.Domain.Result;

    public interface IBaseValidator<T> where T : class
    {
        BaseResult ValidateOnNull(T model);
    }
}
