namespace NetCoreProject.Domain.Enums
{
    public enum ErrorCodes
    {
        ReportsNotFound = 0,
        ReportNotFound = 1,
        ReportAlreadyExists = 2,

        UsersNotFound = 10,
        UserNotFound = 11,
        UserAlreadyExists = 12,

        InternalServerError = 20
    }
}
