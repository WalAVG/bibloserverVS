using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblo.DataLayer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Biblo.DataLayer.Data;

namespace Biblo.Api
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
            Api.Configuration.Cors.Configure(services, "Cors");
            Api.Configuration.Mapping.Configure();
            Api.Configuration.Services.Configure(services);
            services.AddDbContext<BibloDbContext>(options => options.UseInMemoryDatabase(databaseName: "BibloDB").UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, BibloDbContext bibloDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //lancia, distrugge il db, e ne crea uno nuovo
                //se voglio tenere il vecchio db, metto sotto commento sta roba
                bibloDbContext.Database.EnsureDeleted();
                bibloDbContext.Database.EnsureCreated();
                FakeData.InitializeApp(bibloDbContext);
            }
            else
            {
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseCors("Cors");
            app.UseMvc();
        }
    }
}
