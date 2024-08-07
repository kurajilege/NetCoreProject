namespace NetCoreProject.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using NetCoreProject.Domain.Dto.Report;
    using NetCoreProject.Domain.Interfaces;
    using NetCoreProject.Domain.Result;

    //[Authorize]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<BaseResult<ReportDto>>> GetReport(long id)
        {
            var response = await _reportService.GetReportByIdAsync(id);

            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}