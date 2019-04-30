
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DB.Services.Implementation;
using DB.Services.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using Microsoft.Extensions.DependencyInjection;
using PProject.Models;

[assembly: OwinStartupAttribute(typeof(PProject.Startup))]
namespace PProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var services = new ServiceCollection();

            ConfigureServices(services);

            ConfigureAuth(app);

            var resolver = new DefaultDependencyResolver(services.BuildServiceProvider());
            DependencyResolver.SetResolver(resolver);
        }

        private void ConfigureServices(IServiceCollection services)
        {
            //Add the database itself
            services.AddTransient(typeof(ApplicationDbContext));
            //Add dependency injection for the residents service
            services.AddTransient(typeof(IResidentsService), s => new ResidentsService());
            //Add dependency injection for the buildings and residences service.
            services.AddTransient(typeof(IResidencesService), s => new ResidencesService());
            //Add dependency injection for the repairs service.
            services.AddTransient(typeof(IRepairsService), s => new RepairsService());
            //Add dependency injection for the rental service.
            services.AddTransient(typeof(IRentalService), s => new RentalService());

            services.AddController(typeof(Startup).Assembly.GetExportedTypes()
                .Where(t => !t.IsAbstract && !t.IsGenericTypeDefinition)
                .Where(t => typeof(IController).IsAssignableFrom(t)
                            || t.Name.EndsWith("Controller", StringComparison.OrdinalIgnoreCase)));
        }
    }
    /// <summary>
    /// Extension for the IServiceCollection - allows for adding a controller as a service.
    /// </summary>
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddController(this IServiceCollection services, IEnumerable<Type> serviceTypes)
        {
            foreach (var type in serviceTypes)
            {
                services.AddTransient(type);
            }

            return services;
        }
    }
}
