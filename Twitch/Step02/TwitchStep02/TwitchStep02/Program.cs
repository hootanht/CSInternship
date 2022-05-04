using Microsoft.EntityFrameworkCore;

using TwitchStep02.Data.Context;
using TwitchStep02.Interfaces;
using TwitchStep02.Repositories;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
// Add DbContext to the container.
builder.Services.AddDbContext<Twitch02DBContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SqlliteConnection")));

// Injection of services into the application.
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

WebApplication? app = builder.Build();

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
