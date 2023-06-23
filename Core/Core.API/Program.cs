using Core.API.Mappings.Payroll;
using Core.API.Utilities;
using Core.Application;
using Core.Infrastructure;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

try
{
    Log.Information("Starting web host");

    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    // Slugify nested folder structure requirements
    builder.Services.AddControllers(options =>
    {
        options.Conventions.Add(new RouteTokenTransformerConvention(
            new SlugifyParameterTransformer()));
    });

    // Add app dependencies here
    builder.Services
        .AddInfrastructure()
        .AddApplication()
        ;

    // Add mappings here
    builder.Services
        .AddAutoMapper(typeof(PayrollMap))
        ;

    // Custom logging
    builder.Host.UseSerilog(
        (context, configuration) =>
        {
            // Config defined in `appsettings.json` but I can't get it to work right
            configuration.ReadFrom.Configuration(context.Configuration);
            /*configuration.WriteTo.Console();
            configuration.WriteTo.File(
                "/logs/log-.txt",
                Serilog.Events.LogEventLevel.Information
                );*/
        }
    );

    var app = builder.Build();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseSerilogRequestLogging();

    app.UseHttpsRedirection();

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated");
}
finally
{
    Log.CloseAndFlush();
}