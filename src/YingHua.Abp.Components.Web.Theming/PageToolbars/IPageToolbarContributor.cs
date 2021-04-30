using System.Threading.Tasks;

namespace YingHua.Abp.Compnents.Web.Theming.PageToolbars
{
    public interface IPageToolbarContributor
    {
        Task ContributeAsync(PageToolbarContributionContext context);
    }
}
