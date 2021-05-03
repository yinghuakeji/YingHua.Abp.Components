using Volo.Abp.AspNetCore.Components.Web.BasicTheme;
using Volo.Abp.Http.Client.IdentityModel.WebAssembly;
using Volo.Abp.Modularity;
using YingHua.Abp.Compnents.Web.Theming.Routing;
using YingHua.Abp.Compnents.Web.Theming.Toolbars;
using YingHua.Abp.Components.WebAssembly.Theming;

namespace YingHua.Abp.Components.WebAssembly.SyncfusionTheme
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsWebBasicThemeModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule),
        typeof(AbpHttpClientIdentityModelWebAssemblyModule)
        )]
    public class YingHuaAbpComponentsWebAssemblySyncfusionThemeModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpRouterOptions>(options =>
            {
                options.AdditionalAssemblies.Add(typeof(YingHuaAbpComponentsWebAssemblySyncfusionThemeModule).Assembly);
            });

            Configure<AbpToolbarOptions>(options =>
            {
                options.Contributors.Add(new BasicThemeToolbarContributor());
            });
        }
    }
}
