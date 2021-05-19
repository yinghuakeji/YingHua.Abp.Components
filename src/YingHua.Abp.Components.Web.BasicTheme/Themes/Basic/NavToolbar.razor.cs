﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Navigations;
using YingHua.Abp.Compnents.Web.Theming.Toolbars;

namespace YingHua.Abp.Components.Web.BasicTheme.Themes.Basic
{
    public partial class NavToolbar
    {
        private Toolbar toolbar;

        [Inject]
        private IToolbarManager ToolbarManager { get; set; }

        private List<RenderFragment> ToolbarItemRenders { get; set; } = new List<RenderFragment>();

        protected override async Task OnInitializedAsync()
        {
            this.toolbar = await ToolbarManager.GetAsync(StandardToolbars.Main);

            ToolbarItemRenders.Clear();

            var sequence = 0;
            foreach (var item in toolbar.Items)
            {
                ToolbarItemRenders.Add(builder =>
                {
                    builder.OpenComponent(sequence++, item.ComponentType);
                    builder.CloseComponent();
                });
            }
        }

    }
}
