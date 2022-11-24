using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Infra.IoC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<BankingDbContext>(options =>
{

    options.UseSqlServer(builder.Configuration.GetConnectionString("BankingDbConnection"));
});
void ConfigureServices(IServiceCollection services)
{

    RegisterServices(services);
}

void RegisterServices(IServiceCollection services)
{
    DependencyContainer.RegisterServices(services);
}

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
