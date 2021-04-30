using System.Threading.Tasks;

namespace YingHua.Abp.Compnents.Web.Theming.PageToolbars
{
    public interface IPageToolbarManager
    {
        Task<PageToolbarItem[]> GetItemsAsync(PageToolbar toolbar);
    }
}
