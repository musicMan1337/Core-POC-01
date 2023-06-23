using Core.Domain.Payroll.Interfaces;
using Core.Infrastructure.Services.Payroll;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // Add services here
        services
            .AddScoped<IPayrollRepository, PayrollRepositoryMock>()
            ;

        return services;
    }
}
