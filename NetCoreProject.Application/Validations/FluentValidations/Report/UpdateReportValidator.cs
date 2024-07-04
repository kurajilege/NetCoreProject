namespace NetCoreProject.Application.Validations.FluentValidations.Report
{
    using FluentValidation;
    using NetCoreProject.Domain.Dto.Report;

    public class UpdateReportValidator : AbstractValidator<UpdateReportDto>
    {
        public UpdateReportValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Description).NotEmpty().MaximumLength(2000);
        }
    }
}
