using Volo.Abp.Bundling;

namespace YingHua.Abp.Components.WebAssembly.Theming
{
    public class ComponentsComponentsBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
            context.Add("_content/Microsoft.AspNetCore.Components.WebAssembly.Authentication/AuthenticationService.js");
            context.Add("_content/Volo.Abp.AspNetCore.Components.Web/libs/abp/js/abp.js");
        }

        public void AddStyles(BundleContext context)
        {
            // context.BundleDefinitions.Insert(0, new BundleDefinition
            // {
            //     Source = "_content/YingHua.Abp.Components.WebAssembly.Theming/libs/bootstrap/css/bootstrap.min.css"
            // });
            // context.BundleDefinitions.Insert(1, new BundleDefinition
            // {
            //     Source = "_content/YingHua.Abp.Components.WebAssembly.Theming/libs/fontawesome/css/all.css"
            // });
         //   context.Add("_content/YingHua.Abp.Components.WebAssembly.Theming/libs/flag-icon/css/flag-icon.css");
            context.Add("_content/Syncfusion.Blazor.Themes/bootstrap4.css");
        }
    }
}
