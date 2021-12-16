using FastAdmin.DAL;
using FastAdmin.DLL;
using FastAdmin.IDAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FastAdmin.Framework
{
    public class Startup
    {

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // 添加controllers服务
            services.AddControllers();
            // 注入UserService 服务
            services.AddScoped<IUserDal, UserDal>();
            services.AddScoped<IUserDll, UserDll>();

            /* var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json")
             .Build();
             services.AddDbContext<FnvContext>(options => options.UseMySql(builder.GetConnectionString("Database")));*/
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // 启用控制器映射
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
