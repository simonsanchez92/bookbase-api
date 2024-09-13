using Bookbase.Application.Extensions;
using Bookbase.Application.Mappings;
using Bookbase.Extensions;
using Bookbase.Infrastructure.Contexts;
using Bookbase.Infrastructure.Extensions;
using Bookbase.Middleware;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//Swagger extension
builder.Services.AddCustomSwagger();

//Infrastructure
builder.Services.AddInfrastructureServices();

//Application
builder.Services.AddApplicationServices();

//Validations
builder.Services.AddCustomValidators();

//Configure DB Context
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));



//Add Authorization and Authentication
builder.Services.AddCustomAuth(builder.Configuration);


builder.Services.AddAutoMapper(typeof(UserProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
