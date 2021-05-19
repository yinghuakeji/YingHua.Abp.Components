using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Navigations;
using Volo.Abp.UI.Navigation;

namespace YingHua.Abp.Components.Web.BasicTheme.Themes.Basic
{
    public partial class NavMenu
    {
        public class MenuItem
        {
            public string Id { get; set; }
            public string Url { get; set; }
            public string Name { get; set; }
            public string IconCss   { get; set; }
            public bool Expanded { get; set; }
            public List<MenuItem> Items { get; set; }
        }

        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();

        [Inject]
        protected IMenuManager MenuManager { get; set; }

        protected ApplicationMenu Menu { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Menu = await MenuManager.GetAsync(StandardMenus.Main);

            foreach (var menuItem in Menu.Items)
            {
                MenuItems.Add(GetMenu(menuItem));
            }
        }
        private MenuItem GetMenu(ApplicationMenuItem menuItem)
        {
            var menu = new MenuItem()
            {
                Url = menuItem.Url,
                Id = menuItem.Name,
                Name = menuItem.DisplayName,
                Items = null,IconCss = menuItem.CssClass
            };
            Console.WriteLine(menu.Url);
            if (!menuItem.IsLeaf)
            {
                menu.Items = new List<MenuItem>();

                foreach (var menuItemItem in menuItem.Items)
                {
                    menu.Items.Add(GetMenu(menuItemItem));
                }
            }
            return menu;
        }
    }
}
