using System.Collections.Generic;
using JetBrains.Annotations;

namespace YingHua.Abp.Compnents.Web.Theming.Toolbars
{
    public class AbpToolbarOptions
    {
        [NotNull]
        public List<IToolbarContributor> Contributors { get; }

        public AbpToolbarOptions()
        {
            Contributors = new List<IToolbarContributor>();
        }
    }
}
