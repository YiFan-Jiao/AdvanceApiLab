using AdvanceApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("TestContextConnection");

builder.Services.AddDbContext<TestDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

var app = builder.Build();

app.Run();

