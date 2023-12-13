using AutoMapper;
using LMS.Data.Entities;
using LMS.Data.Repositories;
using LMS.Data.Repositories.Aidat;
using LMS.Data.Repositories.Daire;
using LMS.Data.Repositories.Fatura;
using LMS.Data.Repositories.Odeme;
using LMS.Data.Repositories.User;
using LMS.Services.Service.AidatService;
using LMS.Services.Service.DaireService;
using LMS.Services.Service.FaturaService;
using LMS.Services.Service.OdemeService;
using LMS.Services.Service.UserService;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//cors Plitikasý
builder.Services.AddCors(options =>
{ 
    options.AddPolicy(name: "AllowAll", configurePolicy:builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});
//veritabanýna baðlanma
builder.Services.AddDbContext<LMSDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"));
});
//dependency Injection
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IDaireRepositories, DaireRepositories>();
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<IDaireService, DaireService>();
builder.Services.AddScoped<IFaturaSerive, FaturaService>();
builder.Services.AddScoped<IFatruraRepositories, FaturaRepositories>();
builder.Services.AddScoped<IAidatService, AidatService>();
builder.Services.AddScoped<IAidatRepositories, AidatRepositories>();
builder.Services.AddScoped<IOdemeRepostory, OdemeRepostory>();
builder.Services.AddScoped<IOdemeService, OdemeService>();
//aouto mapping config
var mapperConfing = new MapperConfiguration(mc =>
{
    mc.AddProfile(new LMS.Services.Mappers.MappingProfile());
});
IMapper mappper = mapperConfing.CreateMapper();
builder.Services.AddSingleton(mappper);



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
app.UseCors("AllowAll");
app.Run();
