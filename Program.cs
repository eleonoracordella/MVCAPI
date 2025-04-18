using Microsoft.EntityFrameworkCore;
using MVCAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("AteneoConn")));


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

//dico al builder "da qualunque origine arrivi, tu bypassa tutto ed esegui"!
//accetta ogni metodo e ogni origine

app.UseCors(builder =>
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyOrigin()
    );

app.Run();
