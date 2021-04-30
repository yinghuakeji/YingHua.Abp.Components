using System.Threading.Tasks;

namespace YingHua.Abp.Compnents.Web.Theming.Toolbars
{
    public interface IToolbarManager
    {
        Task<Toolbar> GetAsync(string name);
    }
}
