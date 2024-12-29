var builder = WebApplication.CreateBuilder(args);

//Register services

var app = builder.Build();

// configure pipline

app.Run();
