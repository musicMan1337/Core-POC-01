using Shouldly;

namespace Core.Application.Payroll;

public class PayrollUnitTests
{
    [SetUp]
    public void SetUp()
    {
    }

    [Test]
    public void PayrollUnitTest()
    {
        var payroll = new Payroll();
        payroll.ShouldNotBeNull();
    }
}
