using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Volo.Abp.UI.Navigation;

namespace YingHua.Abp.Components.Web.BasicTheme.Themes.Basic
{
    public partial class NavMenu
    {
        [Inject]
        protected IMenuManager MenuManager { get; set; }

        protected ApplicationMenu Menu { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Menu = await MenuManager.GetAsync(StandardMenus.Main);
        }
    }
}
