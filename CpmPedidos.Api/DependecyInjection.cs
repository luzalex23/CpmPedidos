using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CpmPedidos.Api
{
    public class DependecyInjection
    {
        public static void Register(IServiceCollection serviceProvider)
        {
            RepositoryDependence(serviceProvider);
        }

        private static void RepositoryDependence(IServiceCollection serviceProvider)
        {
            
        }
    }
}
