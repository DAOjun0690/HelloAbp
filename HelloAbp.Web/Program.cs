using HelloAbp.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication<AppModule>();

var app = builder.Build();
app.InitializeApplication();

app.Run();
