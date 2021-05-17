using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;
using YingHua.Abp.SyncfusionUI;

// ReSharper disable once CheckNamespace
namespace  Volo.Abp.AspNetCore.Components.Web.Theming
{
    [DependsOn(
        typeof(SyncfusionModule),
        typeof(AbpUiNavigationModule)

        )]
    public class AbpAspNetCoreComponentsWebThemingModule : AbpModule
    {
        
    }
}