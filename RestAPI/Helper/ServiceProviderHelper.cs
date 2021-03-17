using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Helper
{
    public static class ServiceProviderHelper
    {
        public static void SetServiceProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        private static IServiceProvider _serviceProvider;

        public static T GetService<T>()
        {
            return (T) _serviceProvider.GetService(typeof(T));
        }
    }
}
