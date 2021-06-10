using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Components.Web.Basic.Toolbars;

namespace Volo.Abp.AspNetCore.Components.WebAssembly.BootstrapTheme
{
    public class BootstrapThemeToolbarContributor : IToolbarContributor
    {
        /// <summary>
        /// 添加工具栏
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
        {
            if (context.Toolbar.Name == StandardToolbars.Main)
            {
                // context.Toolbar.Items.Add(new ToolbarItem(typeof(LanguageSwitch)));
                // context.Toolbar.Items.Add(new ToolbarItem(typeof(LoginDisplay)));
            }

            return Task.CompletedTask;
        }
    }
}