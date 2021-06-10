using System.Threading.Tasks;

namespace Volo.Abp.AspNetCore.Components.Web.Basic.Toolbars
{
    public interface IToolbarManager
    {
        Task<Toolbar> GetAsync(string name);
    }
}
