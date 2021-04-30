using Volo.Abp.BlazoriseUI;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

// ReSharper disable once CheckNamespace
namespace  Volo.Abp.AspNetCore.Components.Web.Theming
{
    [DependsOn(
        typeof(AbpBlazoriseUIModule),
        typeof(AbpUiNavigationModule)
        )]
    public class AbpAspNetCoreComponentsWebThemingModule : AbpModule
    {
        
    }
}