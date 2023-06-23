namespace Core.Domain.Payroll.Interfaces;

public interface IPayrollRepository
{
    List<Entities.PayrollEntity> GetPayroll();
}

