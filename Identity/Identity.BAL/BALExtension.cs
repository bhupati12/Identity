using System.Reflection;
using FluentValidation;
using Identity.BAL.IService;
using Identity.BAL.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Identity.BAL;

public static class BALExtension
{
    public static IServiceCollection AddBALServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.Configure<JWTOptions>(configuration.GetSection("JWTOptions"));

        services
        .AddFluentEmail(configuration["EmailOptions:DefaultFromEmail"])
        .AddSmtpSender(configuration["EmailOptions:Host"],
                        configuration.GetValue<int>("EmailOptions:Port"),
                        configuration["EmailOptions:UserName"],
                        configuration["EmailOptions:Password"]
                    );


        services.AddTransient<IEmailService, EmailService>();
        return services;
    }
}
