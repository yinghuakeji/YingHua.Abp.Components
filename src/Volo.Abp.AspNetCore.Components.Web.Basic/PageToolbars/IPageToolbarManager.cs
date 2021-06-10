using System.Threading.Tasks;

namespace Volo.Abp.AspNetCore.Components.Web.Basic.PageToolbars
{
    public interface IPageToolbarManager
    {
        Task<PageToolbarItem[]> GetItemsAsync(PageToolbar toolbar);
    }
}
