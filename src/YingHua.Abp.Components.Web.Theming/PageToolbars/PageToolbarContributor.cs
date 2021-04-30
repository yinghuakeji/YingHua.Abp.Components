using System.Threading.Tasks;

namespace YingHua.Abp.Compnents.Web.Theming.PageToolbars
{
    public abstract class PageToolbarContributor : IPageToolbarContributor
    {
        public abstract Task ContributeAsync(PageToolbarContributionContext context);
    }
}
