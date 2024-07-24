using Kama.ApiManagement.Helper;
using Kama.ApiManagement.Tools;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.Threading;

namespace Kama.ApiManagement
{
    public class Startup
    {
        public Startup(Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
            {
                builder.WithOrigins("*")
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddControllers();
            addSwaggerGen(services);

            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);
            ApiRequest.SetProperty(Configuration);
            GetAuthorizationClaims.SetProperty(Configuration);

            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            services.AddHttpContextAccessor();

            services.AddMemoryCache();

            services.AddSignalR();
            //services.AddSignalR();
            #region IOC
            //Library
            Tools.Container.Init(services);

            Domain.Startup.Instance.ConfigureServices(services);
            Infrastructure.DAL.Startup.Instance.ConfigureServices(services);

            services.AddScoped<Core.IRequestInfo, Tools.RequestInfo>();

            services.AddSingleton<Kama.AppCore.IObjectSerializer, Tools.ObjectSerializer>();
            services.AddSingleton<Core.Service.IJwtHelper, Tools.JwtHelper>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<Core.Service.IQrHelper, Tools.QrHelper>();
            services.AddScoped<Core.IApiHubServerUrl, ApiHubServerUrl>();

            var limitatioanJson = Configuration.GetSection("ActivityLog:limitation").Get<LimitationRequest>();
            Infrastructure.Log.Startup.Instance.ConfigureServices(services, limitatioanJson);
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            //if (env.IsDevelopment())
            //{
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Kama.ApiManagement.Core.API v1"));
            //}
            //app.UseRequestLogging();

            app.UseRouting();

            app.UseStaticFiles();
            //app.UseCors();

            //global cors policy
            app.UseCors(x => x
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .SetIsOriginAllowed(origin => true) // allow any origin
                    .AllowCredentials()); // allow credentials

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseMiddleware<Tools.GetAuthorizationClaims>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                string url = $"/apiHub";
                endpoints.MapHub<ApiHub>(url);
            });

        }

        private void addSwaggerGen(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Kama.ApiManagement", Version = "v1" });
                c.CustomSchemaIds(DocumentType => DocumentType.ToString());
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "Please enter into field the word 'Bearer' following by space and JWT",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement {{new OpenApiSecurityScheme{
                    Reference = new OpenApiReference{
                          Type = ReferenceType.SecurityScheme,
                          Id = "Bearer"
                        }
                },new string[] { }} });
            });
        }
    }
}
