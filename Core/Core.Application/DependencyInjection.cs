using Core.Application.Services.Benefits;
using Core.Application.Services.Payroll;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = typeof(DependencyInjection).Assembly;

        services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(assembly));

        services.AddValidatorsFromAssembly(assembly);

        // Add services here
        services
            .AddScoped<PayrollService>()
            .AddScoped<BenefitsService>()
            ;

        return services;
    }
}

