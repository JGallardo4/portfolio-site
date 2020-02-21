using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Portfolio.Data;

namespace Portfolio
{
	public class Startup
	{
  	// This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContextPool<AppDbContext>(x => x
        .UseMySql("Server=localhost;Database=Portfolio;Uid=portfolio;Pwd=4444;",
          mySqlOptions => 
          {
            mySqlOptions
              .ServerVersion(new Version(10, 4, 11), ServerType.MariaDb);
          })
      );
			
			services.AddControllersWithViews();
    }

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
    	if (env.IsDevelopment())
      {
				app.UseDeveloperExceptionPage();
      }

      app.UseHttpsRedirection();
      app.UseStaticFiles();
      app.UseRouting();
			
      app.UseEndpoints(endpoints =>
      {
				endpoints.MapControllerRoute(
        	name: "default",
          pattern: "{controller=Home}/{action=Index}/{id?}");
      });
		}
  }
}
