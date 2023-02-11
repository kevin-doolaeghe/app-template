using backend.Services;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString("MariaDbConnectionString");
builder.Services.AddDbContext<DatabaseContext>(options => options.UseMySql(
    connectionString,
    ServerVersion.AutoDetect(connectionString)
));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseAuthorization();
app.UseStaticFiles();
app.UseDefaultFiles();

app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
