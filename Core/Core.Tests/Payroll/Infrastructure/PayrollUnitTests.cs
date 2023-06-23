using Core.Infrastructure.Services.Payroll;
using Shouldly;

namespace Core.Tests.Payroll.Infrastructure;

[TestFixture]
public class PayrollUnitTests
{
    private PayrollRepositoryMock _payrollRepo;

    [SetUp]
    public void SetUp()
    {
        _payrollRepo = new PayrollRepositoryMock();
    }

    [Test]
    public void PayrollRepoExists()
    {
        _payrollRepo.ShouldNotBeNull();
    }
}

