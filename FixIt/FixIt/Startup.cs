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
using FixIt.Models.Models.ServiceRequest;
using FixIt.Models.Models.Job;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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

            //identity
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            //authentication
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]))
                };
            });
            
            //password config for identity
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 4;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireDigit = false;
            });

            services.AddAutoMapper(typeof(Startup));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IBaseCRUDService<UserViewModel, object, object, UserSearchModel>, BaseCRUDService<User, UserViewModel, object, object, UserSearchModel>>();
            services.AddScoped<IBaseCRUDService<ServiceViewModel, ServiceInsertModel, ServiceUpdateModel, ServiceSearchModel>, BaseCRUDService<Service, ServiceViewModel, ServiceInsertModel, ServiceUpdateModel, ServiceSearchModel>>();
            services.AddScoped<IBaseCRUDService<ServiceTypeModel, ServiceTypeModel, ServiceTypeModel, object>, BaseCRUDService<ServiceType, ServiceTypeModel, ServiceTypeModel, ServiceTypeModel, object>>();
            services.AddScoped<IBaseCRUDService<CityViewModel, object, object, object>, BaseCRUDService<City, CityViewModel, object, object, object>>();
            services.AddScoped<IBaseCRUDService<SexViewModel, object, object, object>, BaseCRUDService<Sex, SexViewModel, object, object, object>>();
            services.AddScoped<IBaseCRUDService<ProfessionViewModel, object, object, object>, BaseCRUDService<Profession, ProfessionViewModel, object, object, object>>();
            services.AddScoped<IBaseCRUDService<PaymentTypeViewModel, object, object, object>, BaseCRUDService<PaymentType, PaymentTypeViewModel, object, object, object>>();
            services.AddScoped<IBaseCRUDService<JobStatusViewModel, object, object, object>, BaseCRUDService<JobStatus, JobStatusViewModel, object, object, object>>();
            services.AddScoped<IBaseCRUDService<ServiceRatingViewModel, ServiceRatingInsertModel, ServiceRatingUpdateModel, object>, BaseCRUDService<ServiceRating, ServiceRatingViewModel, ServiceRatingInsertModel, ServiceRatingUpdateModel, object>>();
            services.AddScoped<IBaseCRUDService<PaymentViewModel, PaymentInsertModel, object, object>, BaseCRUDService<Payment, PaymentViewModel, PaymentInsertModel, object, object>>();
            services.AddScoped<IBaseCRUDService<ServiceRequestViewModel, ServiceRequestInsertModel, object, object>, BaseCRUDService<ServiceRequest, ServiceRequestViewModel, ServiceRequestInsertModel, object, object>>();
            services.AddScoped<IBaseCRUDService<JobViewModel, JobInsertModel, object, JobSearchModel>, BaseCRUDService<Job, JobViewModel, JobInsertModel, object, JobSearchModel>>();

            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IServiceService, ServiceService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IServiceRequestService, ServiceRequestService>();
            
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

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
