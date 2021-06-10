using Volo.Abp.Bundling;

namespace Volo.Abp.AspNetCore.Components.WebAssembly.BootstrapTheme
{
    public class BootstrapThemeBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
            context.Add("_content/Microsoft.AspNetCore.Components.WebAssembly.Authentication/AuthenticationService.js");
            context.Add("_content/Volo.Abp.AspNetCore.Components.Web/libs/abp/js/abp.js");
            context.Add("_content/BootstrapBlazor/js/bootstrap.blazor.bundle.min.js");
        }

        public void AddStyles(BundleContext context)
        {
            context.BundleDefinitions.Insert(0, new BundleDefinition
            {
                Source = "_content/BootstrapBlazor/css/bootstrap.blazor.bundle.min.css"
            });
            
        }
    }
}