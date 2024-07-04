namespace NetCoreProject.Application.DependencyInjection
{
    using FluentValidation;
    using Microsoft.Extensions.DependencyInjection;
    using NetCoreProject.Application.Mapping;
    using NetCoreProject.Application.Services;
    using NetCoreProject.Application.Validations;
    using NetCoreProject.Application.Validations.FluentValidations.Report;
    using NetCoreProject.Domain.Dto.Report;
    using NetCoreProject.Domain.Interfaces;

    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.InitMappers();

            services.InitServices();
        }

        private static void InitMappers(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ReportMapper));
        }

        private static void InitServices(this IServiceCollection services)
        {
            services.AddScoped<IValidator<CreateReportDto>, CreateReportValidator>();
            services.AddScoped<IValidator<UpdateReportDto>, UpdateReportValidator>();

            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<IReportValidator, ReportValidator>();
        }
    }
}
