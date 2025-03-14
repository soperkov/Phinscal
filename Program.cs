using Microsoft.EntityFrameworkCore;
using Phinscal.Components;
using Phinscal.Models;
using Phinscal.Services;

namespace Phinscal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("PhinscalContext") ??
            throw new InvalidOperationException("Connection string CinemaContext not found")));

            builder.Services.AddScoped<UserService>();
            builder.Services.AddScoped<OrderService>();

            builder.Services.AddSingleton<LoggedInUserModel>();

            builder.Services.AddBlazorBootstrap();

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
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
