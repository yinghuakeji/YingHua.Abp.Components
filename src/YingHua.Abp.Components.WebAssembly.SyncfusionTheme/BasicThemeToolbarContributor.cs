﻿using System.Threading.Tasks;
using Syncfusion.Blazor.Navigations;
using YingHua.Abp.Compnents.Web.Theming.Toolbars;
using YingHua.Abp.Components.WebAssembly.SyncfusionTheme.Themes.Basic;
using ToolbarItem = YingHua.Abp.Compnents.Web.Theming.Toolbars.ToolbarItem;

namespace YingHua.Abp.Components.WebAssembly.SyncfusionTheme
{
    public class BasicThemeToolbarContributor : IToolbarContributor
    {
        public Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
        {
            if (context.Toolbar.Name == StandardToolbars.Main)
            {
                context.Toolbar.Items.Add(new ToolbarItem(typeof(LanguageSwitch)));
            context.Toolbar.Items.Add(new ToolbarItem(typeof(LoginDisplay)));
            }

            return Task.CompletedTask;
        }
    }
}
