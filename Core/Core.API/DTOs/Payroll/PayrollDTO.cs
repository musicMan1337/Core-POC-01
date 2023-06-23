namespace Core.API.DTOs.Payroll;

public class PayrollDTO
{
    public int RowId { get; set; }
    public required string Entity { get; set; }
    public double Salary { get; set; }
}

