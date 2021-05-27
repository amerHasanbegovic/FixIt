using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.User;
using FixIt.Models.Models.Service;
using FixIt.Models.Models.ServiceType;
using FixIt.Services.Interfaces;
using FixIt.Services.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using FixIt.Models.Models.City;
using FixIt.Models.Models.Sex;
using FixIt.Models.Models.Profession;
using FixIt.Models.Models.PaymentType;
using FixIt.Models.Models.JobStatus;
using FixIt.Models.Models.ServiceRating;
using FixIt.Models.Models.Payment;

namespace FixIt
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
            services.AddSwaggerGen();
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("FixIt")));
            services.AddAutoMapper(typeof(Startup));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IBaseCRUDService<UserViewModel, object, object>, BaseCRUDService<User, UserViewModel, object, object>>();
            services.AddScoped<IBaseCRUDService<ServiceViewModel, ServiceInsertModel, ServiceUpdateModel>, BaseCRUDService<Service, ServiceViewModel, ServiceInsertModel, ServiceUpdateModel>>();
            services.AddScoped<IBaseCRUDService<ServiceTypeModel, ServiceTypeModel, ServiceTypeModel>, BaseCRUDService<ServiceType, ServiceTypeModel, ServiceTypeModel, ServiceTypeModel>>();
            services.AddScoped<IBaseCRUDService<CityViewModel, object, object>, BaseCRUDService<City, CityViewModel, object, object>>();
            services.AddScoped<IBaseCRUDService<SexViewModel, object, object>, BaseCRUDService<Sex, SexViewModel, object, object>>();
            services.AddScoped<IBaseCRUDService<ProfessionViewModel, object, object>, BaseCRUDService<Profession, ProfessionViewModel, object, object>>();
            services.AddScoped<IBaseCRUDService<PaymentTypeViewModel, object, object>, BaseCRUDService<PaymentType, PaymentTypeViewModel, object, object>>();
            services.AddScoped<IBaseCRUDService<JobStatusViewModel, object, object>, BaseCRUDService<JobStatus, JobStatusViewModel, object, object>>();
            services.AddScoped<IBaseCRUDService<ServiceRatingViewModel, ServiceRatingInsertModel, ServiceRatingUpdateModel>, BaseCRUDService<ServiceRating, ServiceRatingViewModel, ServiceRatingInsertModel, ServiceRatingUpdateModel>>();
            services.AddScoped<IBaseCRUDService<PaymentViewModel, PaymentInsertModel, object>, BaseCRUDService<Payment, PaymentViewModel, PaymentInsertModel, object>>();

            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IServiceService, ServiceService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
