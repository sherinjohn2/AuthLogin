using Microsoft.EntityFrameworkCore;
using AuthLogin.Models;
using AuthLogin.Repositories;
using AuthLogin.Models.DTO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace AuthLogin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<ILogin, AuthenticateLogin>();

            builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("conn")));  //added connection string

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
        }

        //public static void ConfigureServices(IServiceCollection services)
        //{
        //    builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("conn")));
        //    services.AddScoped<ILogin, AuthenticateLogin>();

        //    services.AddControllersWithViews();
        //}
    }
}