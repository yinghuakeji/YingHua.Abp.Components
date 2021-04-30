using System.Threading.Tasks;

namespace YingHua.Abp.Compnents.Web.Theming.Toolbars
{
    public interface IToolbarContributor
    {
        Task ConfigureToolbarAsync(IToolbarConfigurationContext context);
    }
}