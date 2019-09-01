using Csla;
using Csla.Configuration;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorExample.Client
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddCsla();
    }

    public void Configure(IComponentsApplicationBuilder app)
    {
      app.AddComponent<App>("app");

      CslaConfiguration.Configure().
        ContextManager(typeof(Csla.Blazor.ApplicationContextManager)).
        //DefaultServiceProvider(services.BuildServiceProvider()).
        DataPortal().
          DefaultProxy(typeof(Csla.DataPortalClient.HttpProxy), "/api/DataPortal");
    }
  }
}
