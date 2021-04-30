using Volo.Abp.Bundling;

namespace YingHua.Abp.Components.WebAssembly.SyncfusionTheme
{
    public class BasicThemeBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {

        }

        public void AddStyles(BundleContext context)
        {
            context.Add("_content/Syncfusion.Blazor/styles/bootstrap4.css");
        }
    }
}
