using CivicTransportCard.API.Services;
using CivicTransportCard.API.Services.Interface;
using CivicTransportCard.Core.MapperProfile;
using CivicTransportCard.Data.Repositories;
using CivicTransportCard.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CivicTransportCardSqlConn"));
}
);
builder.Services.AddAutoMapper(cfg => cfg.AddMaps(typeof(MappingProfile).Assembly));
////////////DI
//Service
builder.Services.AddScoped<IFareService, FareService>();
builder.Services.AddScoped<ITransportCardService, TransportCardService>();

//Repositories
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IFareRepository, FareRepository>();
builder.Services.AddScoped<ITransportCardRepository, TransportCardRepository>();
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();

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
