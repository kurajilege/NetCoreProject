namespace NetCoreProject.Domain.Interfaces
{
    using System.Threading.Tasks;
    using NetCoreProject.Domain.Dto;
    using NetCoreProject.Domain.Result;

    public interface IReportService
    {
        Task<CollectionResult<ReportDto>> GetReportsAsync(long userId);
    }
}
