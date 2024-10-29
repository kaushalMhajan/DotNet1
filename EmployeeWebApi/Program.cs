using Employment.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<EmpModel>();
var app = builder.Build();

app.UseDefaultFiles();//use to load file in wwwroot/index.html as a default page;

app.UseStaticFiles();//enables static file loading

app.MapControllers();//use for attribute based route-mapping
app.Run();
