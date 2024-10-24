using Employment.Data;
using Employment.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<EmpModel>();

var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
