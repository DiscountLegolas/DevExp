using DevExp.EntityFramework;
using Microsoft.EntityFrameworkCore;
using DevExp.RepositoryPattern.Services.Abstract;
using DevExp.RepositoryPattern.Repositories.Abstract;
using DevExp.RepositoryPattern.Services.Classes;
using DevExp.RepositoryPattern.Repositories.Classes;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DEContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DevExpress")));

builder.Services.AddScoped<ISalesRepo, SalesRepository>();
builder.Services.AddScoped<ISalesService, SalesService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
