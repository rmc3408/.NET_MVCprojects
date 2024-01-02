using Microsoft.EntityFrameworkCore;
using razors_beginner.Repo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Getting variables from AppSettings
string? dbConnection = builder.Configuration.GetConnectionString("razordb");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(dbConnection)
    );


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
