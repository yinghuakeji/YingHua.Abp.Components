using Volo.Abp.Bundling;

namespace YingHua.Abp.Components.WebAssembly.SyncfusionTheme
{
    public class BasicThemeBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
            context.Add("_content/YingHua.Abp.Components.Web.BasicTheme/libs/basic/js/app.js");

        }

        public void AddStyles(BundleContext context)
        {
          //  context.Add("_content/YingHua.Abp.Components.WebAssembly.SyncfusionTheme/libs/abp/css/theme.css");
           // context.Add("_content/YingHua.Abp.Components.WebAssembly.SyncfusionTheme/libs/abp/css/theme.css");
            context.Add("_content/YingHua.Abp.Components.Web.BasicTheme/libs/basic/css/app.css");
            context.Add("_content/YingHua.Abp.Components.Web.BasicTheme/libs/basic/css/devices.css");
        }
    }
}
