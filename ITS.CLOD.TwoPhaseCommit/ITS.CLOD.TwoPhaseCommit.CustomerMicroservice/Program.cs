using ITS.CLOD.TwoPhaseCommit.CustomerMicroservice.Consumer;
using MassTransit;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMassTransit(x =>
{
    x.AddConsumer<PrepareUpdateCustomerConsumer>(); 
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
            e.Consumer<PrepareUpdateCustomerConsumer>(context);
        });
    });
});
builder.Services.AddMassTransitHostedService();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
