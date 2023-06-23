namespace Core.Domain.Payroll.Entities;

public class PayrollEntity
{
    public int RowId { get; set; }
    public required string Entity { get; set; }
    public double Salary { get; set; }
    public int Guid { get; set; }
}

