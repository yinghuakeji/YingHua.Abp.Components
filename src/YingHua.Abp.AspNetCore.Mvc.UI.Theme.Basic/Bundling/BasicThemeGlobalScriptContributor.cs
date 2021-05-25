using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace YingHua.Abp.AspNetCore.Mvc.UI.Theme.Basic.Bundling
{
    public class BasicThemeGlobalScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/themes/basic/layout.js");
            context.Files.Add("/themes/syncfusion/ej2.min.js");
        }
    }
}