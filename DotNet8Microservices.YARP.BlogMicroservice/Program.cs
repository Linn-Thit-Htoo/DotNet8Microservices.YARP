using DotNet8Microservices.YARP.BlogMicroservice.Features;
using DotNet8Microservices.YARP.BlogMicroservice.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<BL_Blog>();
builder.Services.AddScoped<DA_Blog>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<AuthenticationMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();
