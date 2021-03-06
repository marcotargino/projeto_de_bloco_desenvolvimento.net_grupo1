using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using RedeSocial.API.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace RedeSocial.API
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
            services.AddControllers();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //Autenticacao via token JWT
            services.AddTransient<Services.AuthenticateService>();

            var key = Encoding.UTF8.GetBytes(this.Configuration["Token:Secret"]);

            services.AddAuthentication(opt =>
            {
                //opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                 opt.DefaultScheme = "Bearer";

            }).AddJwtBearer(o => {
                //validacoes do token
                o.TokenValidationParameters.ValidIssuer = "RedeSocialAPI";
                o.TokenValidationParameters.ValidAudience = "RedeSocialAPI";
                o.TokenValidationParameters.IssuerSigningKey = new SymmetricSecurityKey(key);

            }); 



            services.AddDbContext<RedeSocialAPIContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("RedeSocial")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            //Outra linha pra validar o token e autenticar a API
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
