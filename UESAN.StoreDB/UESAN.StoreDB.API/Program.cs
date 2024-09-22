using Microsoft.EntityFrameworkCore;
using UESAN.StoreDB.DOMAIN.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

//add services to the container.
var _config = builder.Configuration;
var cnx = _config.GetConnectionString("devconnection");
builder.Services
    .AddDbContext<StoreDbContext> //importar using de domain
    (options => options.UseSqlServer(cnx)); //importar using

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

app.UseAuthorization();

app.MapControllers();

app.Run();
