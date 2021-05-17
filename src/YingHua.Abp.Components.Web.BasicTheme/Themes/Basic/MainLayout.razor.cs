using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Syncfusion.Blazor.Navigations;

namespace YingHua.Abp.Components.Web.BasicTheme.Themes.Basic
{
    public partial class MainLayout : IDisposable
    {
        SfSidebar Sidebar;
        [Inject] private NavigationManager NavigationManager { get; set; }
        public List<MenuItem> AccountMenuItems = new List<MenuItem> {
            new MenuItem {
                Text = "Account",
                Items = new List<MenuItem> {
                    new MenuItem { Text = "Profile" },
                    new MenuItem { Text = "Sign out" }
                }
            }
        };

        public List<MenuItem> MainMenuItems = new List<MenuItem>
        {
            new MenuItem
            {
                Text = "Overview", IconCss = "icon-user icon",
                Items = new List<MenuItem>
                {
                    new MenuItem {Text = "All Data"},
                    new MenuItem {Text = "Category2"},
                    new MenuItem {Text = "Category3"}
                }
            }
        };
        private bool IsCollapseShown { get; set; }

        protected override void OnInitialized()
        {
            NavigationManager.LocationChanged += OnLocationChanged;
        }

        private void ToggleCollapse()
        {
            IsCollapseShown = !IsCollapseShown;
        }

        public void Dispose()
        {
            NavigationManager.LocationChanged -= OnLocationChanged;
        }

        private void OnLocationChanged(object sender, LocationChangedEventArgs e)
        {
            IsCollapseShown = false;
            InvokeAsync(StateHasChanged);
        }
    }
}
