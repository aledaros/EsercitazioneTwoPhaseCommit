using MassTransit;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMassTransit(x =>
{
    x.UsingRabbitMq((context, rabbitConfigurator) =>
    {
        rabbitConfigurator.Host(
            "localhost",
            "/",
            credentials =>
            {
                credentials.Username("guest");
                credentials.Password("guest");
            });
        rabbitConfigurator.ReceiveEndpoint("prepareUpdateCustomerFund", e =>
        {
            e.Consumer<>();
        });
    });
});
builder.Services.AddMassTransitHostedService();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
