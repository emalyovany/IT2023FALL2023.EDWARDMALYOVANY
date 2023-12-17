using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EddiesHikingStore.Data; // Include your Data namespace
using EddiesHikingStore.Controllers; // Include your Controllers namespace

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();

        // Add session state services
        services.AddSession();

        // Add DbContext configuration here using SQL Server
        services.AddDbContext<EddiesHikingStoreContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("EddiesHikingStoreContext")));
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseSession(); // Configure session middleware

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "productdb",
                pattern: "ProductDB", // The URL segment to match
                defaults: new { controller = "Product", action = "ListProducts" }); // Controller and action to invoke

            endpoints.MapControllerRoute(
                name: "contactdb",
                pattern: "ContactDB", // The URL segment to match
                defaults: new { controller = "Contact", action = "Index" }); // Controller and action to invoke

            // Define other routes as needed...

            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
