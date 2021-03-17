using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestAPI.Extensions;

namespace RestAPI.Helper
{
    internal  static class DependencyInjectionHelper
    {
        public static IConfiguration GetConfiguration()
        {
            //var configObj = new
            //{
            //    ConnectionString = "Data Source = .;Initial Catalog = db.local;Integrated Security=true;"
            //};

            //var configJson = JsonConvert.SerializeObject(configObj,Formatting.Indented);

            var configuration = new ConfigurationBuilder()
                .Build(); //TODO

            return configuration;
        }

        internal static void ConfigurationServiceProvider()
        {
            var config = GetConfiguration();

            IServiceProvider serviceProvider = new ServiceCollection()
                .AddLogging((logginbuilder) =>
                {
                    logginbuilder.ClearProviders();
                })
                .AddRestServices(config)
                .BuildServiceProvider();


            ServiceProviderHelper.SetServiceProvider(serviceProvider);
        }
    }
}
