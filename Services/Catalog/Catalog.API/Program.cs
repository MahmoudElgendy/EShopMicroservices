var builder = WebApplication.CreateBuilder(args);

//Register services
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblies(typeof(Program).Assembly);
});

var app = builder.Build();

// configure pipline
app.MapCarter();
app.Run();
