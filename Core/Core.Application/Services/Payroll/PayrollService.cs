using Core.Domain.Payroll.Entities;
using Core.Domain.Payroll.Interfaces;

namespace Core.Application.Services.Payroll;

public class PayrollService
{
    private readonly IPayrollRepository _payrollRepository;

    public PayrollService(IPayrollRepository payrollRepository)
    {
        _payrollRepository = payrollRepository;
    }

    public List<PayrollEntity> GetPayroll()
    {
        return _payrollRepository.GetPayroll();
    }
}

