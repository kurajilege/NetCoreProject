namespace NetCoreProject.Application.Mapping
{
    using AutoMapper;
    using NetCoreProject.Domain.Dto.Report;
    using NetCoreProject.Domain.Entities;

    public class ReportMapper : Profile
    {
        public ReportMapper()
        {
            CreateMap<Report, ReportDto>().ReverseMap();
        }
    }
}
