using System.Threading.Tasks;

namespace Volo.Abp.AspNetCore.Components.Web.Basic.Toolbars
{
    public interface IToolbarContributor
    {
        Task ConfigureToolbarAsync(IToolbarConfigurationContext context);
    }
}