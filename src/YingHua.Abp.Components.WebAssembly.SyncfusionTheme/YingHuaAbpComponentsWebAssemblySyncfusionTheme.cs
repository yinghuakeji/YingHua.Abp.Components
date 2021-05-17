using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;
using Volo.Abp.Application;
using Volo.Abp.AspNetCore.Components.Web;
using Volo.Abp.AspNetCore.Components.WebAssembly;
using Volo.Abp.Authorization;
using Volo.Abp.Http.Client.IdentityModel.WebAssembly;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;
using YingHua.Abp.Compnents.Web.Theming.Routing;
using YingHua.Abp.Compnents.Web.Theming.Toolbars;
using YingHua.Abp.Components.Web.BasicTheme;
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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDM4NzU4QDMxMzkyZTMxMmUzMFNvSVB1WTFGQ3pWL25YRWFwS3hPSXhIcXpXRUExaEg5Zlpia0VaOTZRZjQ9");
            context.Services.AddSingleton(typeof(AbpBlazorMessageLocalizerHelper<>));

            context.Services.AddSyncfusionBlazor();
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
