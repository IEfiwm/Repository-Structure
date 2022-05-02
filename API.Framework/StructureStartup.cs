using Contract.Base.Messaging;
using Domain.Entities.Basic;
using Infrastructure.DbContexts;
using Infrastructure.Identity.Seeds;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Security.Claims;

namespace Api.Framework
{
    public static class StructureStartup
    {
        public static IConfiguration DIConfiguration
        {
            get
            {
                return Common.ConfigurationManager.GetConfiguration();
            }
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(DIConfiguration.GetConnectionString("Main")));

            //var connectionString = DIConfiguration.GetConnectionString("Main");
            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(connectionString));
            services.AddDatabaseDeveloperPageExceptionFilter();

            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<ApplicationDbContext>();
            //services.AddRazorPages();

            services.AddCors(options => options.AddPolicy("CorsPolicy",
                            builder =>
                            {
                                builder.AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader()
                                .SetIsOriginAllowed((host) => true);
                            }));

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                //options.Password.RequireDigit = true;
                //options.Password.RequireLowercase = true;
                //options.Password.RequireNonAlphanumeric = true;
                //options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 8;
                //options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                //options.User.RequireUniqueEmail = true;
            });

            //services.ConfigureApplicationCookie(options =>
            //{
            //    // Cookie settings
            //    options.Cookie.HttpOnly = true;
            //    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

            //    options.LoginPath = "/Identity/Account/Login";
            //    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
            //    options.SlidingExpiration = true;
            //});

            services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
             .AddEntityFrameworkStores<ApplicationDbContext>();

            services.Configure<IdentityOptions>(options =>
            options.ClaimsIdentity.UserIdClaimType = ClaimTypes.NameIdentifier);

            services.AddSingleton<ILoggerFactory, LoggerFactory>();

            services.AddSingleton(typeof(ILogger<>), typeof(Logger<>));

            //var mappingConfig = new MapperConfiguration(mc =>
            //{
            //    mc.Mappers.Clear();
            //    mc.ValidateInlineMaps = false;
            //    mc.AddProfile(new MappingCommunication());
            //    mc.AllowNullCollections = true;
            //    mc.AllowNullDestinationValues = true;
            //    mc.CreateMissingTypeMaps = true;
            //});

            //IMapper mapper = mappingConfig.CreateMapper();

            //services.AddSingleton(mapper);

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddSwaggerGen(opt =>
            {
                opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "bearer",
                });

                opt.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[]{}
                    }
                });
            });

            services.AddControllers();

            //services.AddAuthentication();

            //services.AddAuthenticationCore();

            //services.AddControllers(config =>
            //{
            //    var policy = new AuthorizationPolicyBuilder()
            //                     .RequireAuthenticatedUser()
            //                     .Build();
            //    config.Filters.Add(new AuthorizeFilter(policy));
            //});

            //services.AddAuthorizationCore();

            //services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(DIConfiguration.GetConnectionString("Main"),
            //    providerOptions => providerOptions.EnableRetryOnFailure()));

            //services.AddFluentValidation();

            Contract.DependencyInjector.Start(services);
        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "SMS WebApi v1");
            });

            app.Use(async (context, next) =>
            {
                if (context.Request.Path == "/")
                    //await context.Response.WriteAsync("Server is running ");

                    context.Response.Redirect("/swagger");
                else
                    await next();
            });

            app.UseCors("CorsPolicy");

            //app.UseResponseCompression();
        }

        public static async void ConfigurationDatabase(IServiceProvider serviceProvider)
        {
            await DefaultSeedData.SeedAsync(serviceProvider.GetService<UserManager<ApplicationUser>>(), serviceProvider.GetService<RoleManager<IdentityRole>>());
        }
    }
}