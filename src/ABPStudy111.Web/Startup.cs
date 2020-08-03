using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.PlatformAbstractions;
using ABPStudy111.Application.IServices;
using ABPStudy111.Application.Services;
using ABPStudy111.Repositories.DbContextFile;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Ordering.API.Infrastructure.AutofacModules;

namespace ABPStudy111.Web
{
    public class Startup
    {
        public static IServiceProvider ServiceProvider { get; set; }
        private readonly IHostingEnvironment _env;

        public Startup(IHostingEnvironment env)
        {
            _env = env;
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddAutoMapper();

            services.AddDapper(Configuration.GetConnectionString("WriteConnection"), Configuration.GetConnectionString("ReadConnection"));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("ABPApi", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Version = "V2",
                    Title = "ABP",
                    Description = "Api说明以及测试",
                    TermsOfService = "yunfeng",
                });
            });
            services.ConfigureSwaggerGen(c =>
            {
                c.IncludeXmlComments(GetXmlCommentsPath(PlatformServices.Default.Application));
            });
            services.AddDbContext<TestDbContext>(options => options.UseMySql(Configuration.GetConnectionString("MysqlConnection")));
            services.AddTransient<IOrdersService, OrdersService>();


            var containerBuilder = new ContainerBuilder();

            //containerBuilder.RegisterModule<AutofacInitModule>();
            containerBuilder.RegisterModule(new MediatorModule());

            // Populate 方法是最重要的，如果没有调用这个方法，则无法将注入到 IServiceCollection的内置对象填充到autofac中,像控制器注入，Log注入等，程序会报错。
            containerBuilder.Populate(services);

            var container = containerBuilder.Build();
            return new AutofacServiceProvider(container);
        }
        private string GetXmlCommentsPath(ApplicationEnvironment appEnvironment)
        {
            return Path.Combine(appEnvironment.ApplicationBasePath, "ABPStudy111.Web.xml");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/ABPApi/swagger.json", "ABPApi");
            });
        }
    }
}
