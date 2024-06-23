namespace NetCoreProject.Domain.Interfaces
{
    using System.Threading.Tasks;
    using NetCoreProject.Domain.Dto.Report;
    using NetCoreProject.Domain.Result;

    public interface IReportService
    {
        Task<CollectionResult<ReportDto>> GetReportsAsync(long userId);

        Task<BaseResult<ReportDto>> GetReportByIdAsync(long id);

        Task<BaseResult<ReportDto>> CreateReportAsync(CreateReportDto dto);

        Task<BaseResult<ReportDto>> RemoveReportAsync(long id);

        Task<BaseResult<ReportDto>> UpdateReportAsync(UpdateReportDto dto);
    }
}
