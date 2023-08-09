using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigCores();
builder.Services.AddControllers();
builder.Services.AddAplicationServices();
builder.Services.AddDbContext<TallerRepDbContext>(options =>{
    string ? connectionString = builder.Configuration.GetConnectionString("MysqlConnection");
    options.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString));
});
builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());
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
app.UseCors("CorsPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
