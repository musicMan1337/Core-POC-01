
using Core.Domain.Payroll.Entities;
using Core.Domain.Payroll.Interfaces;

namespace Core.Infrastructure.Services.Payroll;

public class PayrollRepositoryMock : IPayrollRepository
{
    public List<PayrollEntity> GetPayroll()
    {
        return new List<PayrollEntity>
            {
                new PayrollEntity { RowId = 1, Entity = "John", Salary = 100.70, Guid = 54321 },
                new PayrollEntity { RowId = 2, Entity = "Darell", Salary = 160.50 , Guid = 12345 }
            };
    }
}

