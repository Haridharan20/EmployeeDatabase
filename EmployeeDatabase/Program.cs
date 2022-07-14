using Microsoft.EntityFrameworkCore;
using EmployeeDatabase.Models;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "server=localhost;port=3306;user=root;password=root@123;database=Employees";
var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<EmployeeDBContext>(options =>
{
    // options. (builder.Configuration.GetConnectionString("Mysql"));
    object value = options.UseMySql(connectionString, serverVersion);
});


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
