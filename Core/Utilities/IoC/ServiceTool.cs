using Microsoft.Extensions.DependencyInjection;
using System;

namespace Core.Utilities.IoC
{//.Net in servislerini al ve build et
    //Web apide oluşturduğumuz injectionları oluşturmaya yarıyor 
    //istediğim herhangi bir interfacenin karşılığıı almaya yarıyor
    public static class ServiceTool
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
