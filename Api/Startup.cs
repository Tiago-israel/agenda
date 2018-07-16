using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Repositories;
using Api.Repositories.Interfaces;
using Api.Services;
using Aplication;
using Aplication.AutoMapper;
using Aplication.Intefaces;
using Aplication.Interfaces;
using AutoMapper;
using Infra.DataContext;
using Infra.Interfaces;
using Infra.Repositories;
using Infra.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Api
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
            var connection = "Server=localhost;DataBase=agenda;Uid=root;Pwd=";
            services.AddDbContext<AgendaContext>(options => options.UseMySql(connection));
            services.AddScoped<IContatoRepository, ContatoRepository>();
            services.AddScoped<ITelefoneRepository, TelefoneRepository>();
            services.AddScoped<IErrorLogRepository, ErrorLogRepository>();
            services.AddScoped<IContatoAppService, ContatoAppService>();
            services.AddScoped<ITelefoneAppService, TelefoneAppService>();
            services.AddScoped<IErrorLogAppService, ErrorLogAppService>();
            services.AddAutoMapper(x => x.AddProfile(new ViewModelToModel()));
            services.AddCors();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(builder => builder
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader()
               .AllowCredentials());
            app.UseMvc();
        }
    }
}
