using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using WebApi.BaseServices;
using WebApi.ConfigurationServices.IdentityConfigurationServices;
using WebApi.Data;
using WebApi.EntitiesServices;
using WebApi.Extension_Methods;
using WebApi.IdentityUserServices;
using WebApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

string connetction = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(opt => opt.UseNpgsql(connetction));
builder.Services.AddIdentity<User, IdentityRole>()
               .AddEntityFrameworkStores<ApplicationContext>();

builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IAccountService,AccountService>();
builder.Services.AddScoped<IUserService,UserService>();

builder.Services.AddAccountServices(builder);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerServices();

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


//var scope = app.Services.CreateScope();
//var services = scope.ServiceProvider;
//var context = services.GetRequiredService<ApplicationContext>();
//var res = UserRoleConfigurationService.Initialize(context);


//var host=app.Services.GetService<IHostBuilder>();
//var scope= host.
//var services = scope.ServiceProvider;
//var context= services.GetRequiredService<ApplicationContext>();
//Task task = UserRoleConfigurationService.Initialize(context);


app.Run();
