using Album.Data;
using Album.Mail.Album.Mail;
using Album.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Album
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			
			services.AddDbContext<AppDbContext>(options => {
				
				string connectstring = Configuration.GetConnectionString("AppDbContext");
				
				options.UseSqlServer(connectstring);
			});

			services.AddIdentity<AppUser, IdentityRole>()
				.AddEntityFrameworkStores<AppDbContext>()
				.AddDefaultTokenProviders();

			services.Configure<IdentityOptions>(options => {
				options.Password.RequireDigit = false; 
			options.Password.RequireLowercase = false;
			options.Password.RequireNonAlphanumeric = false;
			options.Password.RequireUppercase = false;
			options.Password.RequiredLength = 3;
			options.Password.RequiredUniqueChars = 1; 
			options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); 
			options.Lockout.MaxFailedAccessAttempts = 5; 
			options.Lockout.AllowedForNewUsers = true;

			
			options.User.AllowedUserNameCharacters = 
				"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
			options.User.RequireUniqueEmail = true; 


			options.SignIn.RequireConfirmedEmail = true;            
			options.SignIn.RequireConfirmedPhoneNumber = false;


				services.AddOptions();                                        
				var mailsettings = Configuration.GetSection("MailSettings"); 
				services.Configure<MailSettings>(mailsettings);              

				services.AddTransient<IEmailSender, SendMailService>();        


				services.AddRazorPages();
			services.AddControllersWithViews();
			});

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();
			app.UseAuthentication();
			app.UseAuthorization();


			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
