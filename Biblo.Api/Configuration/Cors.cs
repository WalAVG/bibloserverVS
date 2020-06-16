using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblo.Api.Configuration
{
    public class Cors
    {
        public static void Configure(IServiceCollection services, string policyName)
        {
            services.AddCors(action =>
            {
                var corsPolicy = new CorsPolicy();
                corsPolicy.Headers.Add("*");
                corsPolicy.Methods.Add("*");
                corsPolicy.Origins.Add("*");
                action.AddPolicy(policyName, corsPolicy);
            });
        }
    }
}
