using Volo.Abp.Bundling;

namespace YingHua.Abp.SyncfusionUI
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
