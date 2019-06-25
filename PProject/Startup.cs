
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AuthDB.Services.Implementations;
using AuthDB.Services.Interfaces;
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
            //Add dependency injection for the payment service.
            services.AddTransient(typeof(IPaymentService), s => new PaymentService()); 
            //Add dependency injection for the payment bill service.
            services.AddTransient(typeof(IPaymentBillService), s => new PaymentBillService());
            //Add dependency injection for the repair bill service.
            services.AddTransient(typeof(IRepairBillService), s => new RepairBillService());
            //Add dependency injection for the repair service.
            services.AddTransient(typeof(IRepairsService), s => new RepairsService());
            //Add dependency injection for the fault service.
            services.AddTransient(typeof(IFaultService), s => new FaultService());
            //Add dependency injection for the companies service.
            services.AddTransient(typeof(ICompanyService), s => new CompanyService());
            //Add dependency injection for the user service.
            services.AddTransient(typeof(IUserService), s => new UserService());
            //Add dependency injection for the gsthfdbvydtyf service.
            services.AddTransient(typeof(ILatePaymentService), s => new LatePaymentService());
            //Add dependency injection for the 364w5bybes service.
            services.AddTransient(typeof(IIncomeService), s => new IncomeService());

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
