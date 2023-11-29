using Microsoft.EntityFrameworkCore;
using Task1.DbContexts;
using Task1.Profiles;
using Task1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Load configuration
builder.Configuration.AddJsonFile("appsettings.json");

// Configure Entity Framework
builder.Services.AddDbContext<DbInfo>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

    options.UseSqlServer(connectionString)
           .LogTo(Console.WriteLine, LogLevel.Information)
           .EnableSensitiveDataLogging()
           .EnableDetailedErrors();
});

// Register services
builder.Services.AddScoped<DbService>();
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Enable CORS if needed
// app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
