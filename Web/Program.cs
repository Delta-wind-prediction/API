using Common.interfaces;
using Microsoft.EntityFrameworkCore;
using Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string? connectionString =
    Environment.GetEnvironmentVariable("DatabaseConnectionString");
if (connectionString == null)
    connectionString = "Server=localhost;Database=Power;User=root;Password=root";

builder.Services.AddDbContext<IDataBaseContext, DataBaseContext>(options =>
{
    options.UseSqlServer(connectionString, b => b.MigrationsAssembly("Repository"));
    // options.UseMySql(connectionString, 
        // new MySqlServerVersion(new Version(8, 0)));
});



using (var scope =
       builder.Services.BuildServiceProvider().CreateScope()) {
    using (var context =
           scope.ServiceProvider.GetService<IDataBaseContext>()) {
        if (context != null)
        {
            context.Database.EnsureCreated();
        }
    }
} 

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