using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace PProject
{
    public class DefaultDependencyResolver : IDependencyResolver
    {
        /// <summary>
        /// Stores provided services.
        /// </summary>
        private IServiceProvider _serviceProvider;

        public DefaultDependencyResolver(IServiceProvider services)
        {
            _serviceProvider = services;
        }
        /// <summary>
        /// Get given service.
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public object GetService(Type serviceType)
        {
            return this._serviceProvider.GetService(serviceType);
        }
        /// <summary>
        /// Get all services of provided type.
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this._serviceProvider.GetServices(serviceType);
        }
    }
}