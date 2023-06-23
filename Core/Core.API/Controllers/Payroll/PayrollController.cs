using AutoMapper;
using Core.API.DTOs.Payroll;
using Core.Application.Services.Payroll;
using Microsoft.AspNetCore.Mvc;

namespace Core.API.Controllers.Payroll;

[ApiController]
[Route("api/[controller]/[controller]")]
public class PayrollController : ControllerBase
{
    private readonly ILogger<PayrollController> _logger;
    private readonly IMapper _mapper;
    private readonly PayrollService _payrollService;

    public PayrollController(
        ILogger<PayrollController> logger,
        IMapper mapper,
        PayrollService payrollService
        )
    {
        _logger = logger;
        _mapper = mapper;
        _payrollService = payrollService;

        _logger.LogInformation("Setting up PayrollController");
    }

    [HttpGet("all")]
    public ActionResult<IEnumerable<PayrollDTO>> GetAll(int id)
    {
        _logger.LogInformation("Getting All Payrolls");
        _logger.LogInformation("{@id}", id);

        var payroll = _payrollService.GetPayroll();
        _logger.LogInformation("Payroll: {@payroll}", payroll);

        var payrollDtos = _mapper.Map<List<PayrollDTO>>(payroll);
        _logger.LogInformation("payrollDtos: {@payrollDtos}", payrollDtos);

        return Ok(payrollDtos);
    }
}

