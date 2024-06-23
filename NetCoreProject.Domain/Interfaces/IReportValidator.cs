namespace NetCoreProject.Domain.Interfaces
{
    using NetCoreProject.Domain.Entities;
    using NetCoreProject.Domain.Result;

    public interface IReportValidator : IBaseValidator<Report>
    {
        BaseResult CreateValidator(Report report, User user);
    }
}
