using System;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.JSInterop;
using Syncfusion.Blazor.SplitButtons;
using Volo.Abp.UI.Navigation;

namespace YingHua.Abp.Components.WebAssembly.SyncfusionTheme.Themes.Basic
{
    public partial class LoginDisplay : IDisposable
    {
        [Inject]
        protected IMenuManager MenuManager { get; set; }

        [CanBeNull]
        protected AuthenticationStateProvider AuthenticationStateProvider;

        [CanBeNull]
        protected SignOutSessionStateManager SignOutManager;

        protected ApplicationMenu Menu { get; set; }
        public string Name { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if (CurrentTenant.Name!=null)
            {
                this.Name = $"{CurrentTenant.Name}\\{CurrentUser.UserName}";
            }
            else
            {
                this.Name = $"{CurrentUser.UserName}";
            }
            Menu = await MenuManager.GetAsync(StandardMenus.User);

            Navigation.LocationChanged += OnLocationChanged;

            LazyGetService(ref AuthenticationStateProvider);
            LazyGetService(ref SignOutManager);
            if (AuthenticationStateProvider != null)
            {
                AuthenticationStateProvider.AuthenticationStateChanged += async (task) =>
                {
                    Menu = await MenuManager.GetAsync(StandardMenus.User);
                    await InvokeAsync(StateHasChanged);
                };
            }
        }

        protected virtual void OnLocationChanged(object sender, LocationChangedEventArgs e)
        {
            InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            Navigation.LocationChanged -= OnLocationChanged;
        }

        private async Task NavigateToAsync(string uri, string target = null)
        {
            if (target == "_blank")
            {
                await JsRuntime.InvokeVoidAsync("open", uri, target);
            }
            else
            {
                Navigation.NavigateTo(uri);
            }
        }

        private async Task BeginSignOut()
        {
            if (SignOutManager != null)
            {
                await SignOutManager.SetSignOutState();
                await NavigateToAsync("authentication/logout");
            }
        }

        private async Task ItemSelected(MenuEventArgs arg)
        {
            Console.WriteLine(arg.Item.Id);    
            switch (arg.Item.Id)
            {
                case "Logout":
                    await this.BeginSignOut();
                    break;
            }
        }
 
    }
}
