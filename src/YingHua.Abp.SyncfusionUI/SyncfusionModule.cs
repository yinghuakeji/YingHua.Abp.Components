using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;
using Volo.Abp.Application;
using Volo.Abp.AspNetCore.Components.Web;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace YingHua.Abp.SyncfusionUI
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsWebModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class SyncfusionModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            ConfigureSyncfusionBlazor(context);
        }

        private void ConfigureSyncfusionBlazor(ServiceConfigurationContext context)
        {
            context.Services.AddSyncfusionBlazor();
            context.Services.AddSingleton(typeof(AbpBlazorMessageLocalizerHelper<>));
        }
    }
}
