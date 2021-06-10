using System.Threading.Tasks;

namespace Volo.Abp.AspNetCore.Components.Web.Basic.PageToolbars
{
    public interface IPageToolbarContributor
    {
        Task ContributeAsync(PageToolbarContributionContext context);
    }
}
