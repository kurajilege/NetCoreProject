namespace NetCoreProject.Application.Services
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using NetCoreProject.Application.Resources;
    using NetCoreProject.Domain.Dto;
    using NetCoreProject.Domain.Entities;
    using NetCoreProject.Domain.Enums;
    using NetCoreProject.Domain.Interfaces;
    using NetCoreProject.Domain.Result;
    using Serilog;

    public class ReportService : IReportService
    {
        private readonly IBaseRepository<Report> _reportRepository;
        private readonly ILogger _logger;

        public ReportService(IBaseRepository<Report> reportRepository, ILogger logger)
        {
            _reportRepository = reportRepository;
            _logger = logger;
        }

        public async Task<CollectionResult<ReportDto>> GetReportsAsync(long userId)
        {
            ReportDto[] reports;

            try
            {
                reports = await _reportRepository.GetAll()
                    .Where(x => x.UserId == userId)
                    .Select(x => new ReportDto(x.Id, x.Name, x.Description, x.CreatedAt.ToLongDateString()))
                    .ToArrayAsync();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);

                return new CollectionResult<ReportDto>()
                {
                    ErrorMessage = ErrorMessage.InternalServerError,
                    ErrorCode = (int)ErrorCodes.InternalServerError
                };
            }

            if (reports.Length == 0)
            {
                _logger.Warning(ErrorMessage.ReportsNotFound);

                return new CollectionResult<ReportDto>()
                {
                    ErrorMessage = ErrorMessage.ReportsNotFound,
                    ErrorCode = (int)ErrorCodes.ReportsNotFound
                };
            }

            return new CollectionResult<ReportDto>()
            {
                Data = reports,
                Count = reports.Length
            };
        }
    }
}
