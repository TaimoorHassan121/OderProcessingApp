using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OderProcessingApp.Data;
using OderProcessingApp.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'OrderProcessingApp' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));


// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddTransient<OrderServices>();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

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
