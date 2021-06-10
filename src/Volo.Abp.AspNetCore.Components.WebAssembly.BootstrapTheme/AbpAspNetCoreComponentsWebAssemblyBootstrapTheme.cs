using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Components.Web.Basic;
using Volo.Abp.AspNetCore.Components.Web.Basic.Routing;
using Volo.Abp.AspNetCore.Components.Web.Basic.Toolbars;
using Volo.Abp.Http.Client.IdentityModel.WebAssembly;
using Volo.Abp.Modularity;

namespace Volo.Abp.AspNetCore.Components.WebAssembly.BootstrapTheme
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsWebBasicModule),
        typeof(AbpHttpClientIdentityModelWebAssemblyModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyModule)
        )]
    public class AbpAspNetCoreComponentsWebAssemblyBootstrapThemeModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddBootstrapBlazor();
            Configure<AbpRouterOptions>(options =>
            {
                options.AdditionalAssemblies.Add(typeof(AbpAspNetCoreComponentsWebAssemblyBootstrapThemeModule).Assembly);
            });

            Configure<AbpToolbarOptions>(options =>
            {
                options.Contributors.Add(new BootstrapThemeToolbarContributor());
            });
        }
    }
}
