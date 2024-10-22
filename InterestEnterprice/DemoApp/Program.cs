using DemoApp.Endpoints;
using DemoApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IInterest, SimpleInterest>();
var app = builder.Build();
app.MapGet("/home", Greetings.Welcome);
app.MapPost("/Interest", Greetings.Interest);
app.Run();