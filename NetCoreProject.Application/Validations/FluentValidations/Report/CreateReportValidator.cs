namespace NetCoreProject.Application.Validations.FluentValidations.Report
{
    using FluentValidation;
    using NetCoreProject.Domain.Dto.Report;

    public class CreateReportValidator : AbstractValidator<CreateReportDto>
    {
        public CreateReportValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Description).NotEmpty().MaximumLength(2000);
        }
    }
}
