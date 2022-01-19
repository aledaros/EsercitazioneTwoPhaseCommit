using ITS.CLOD.TwoPhaseCommit.Event.Event;
using MassTransit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

        rabbitConfigurator.ReceiveEndpoint("answerFromCustomer", e =>
        {
            e.Consumer<MessagePrepareEventConsumer>(context);
        });
    });
});
builder.Services.AddMassTransitHostedService();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
