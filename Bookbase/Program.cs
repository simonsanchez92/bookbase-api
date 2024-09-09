using Bookbase.Application.Interfaces;
using Bookbase.Application.Mappings;
using Bookbase.Application.Services;
using Bookbase.Domain.Interfaces;
using Bookbase.Infrastructure.Contexts;
using Bookbase.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Infrastructure
builder.Services.AddTransient<IUserRepository, UserRepository>();


//Application
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IAuthService,  AuthService>();

builder.Services.AddTransient<IUserCreateValidator, UserCreateValidator>();

builder.Services.AddSingleton<IPasswordEncryptionService, PasswordEncryptionService>();
builder.Services.AddSingleton<IJwtTokenService, JwtTokenService>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(UserProfile));

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
