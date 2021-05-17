using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YingHua.Abp.SyncfusionUI.Components
{
    public partial class Modal
    {
        private bool IsVisible { get; set; } = true;
        public void Hide()
        {
            this.IsVisible = false;
        } public void Show()
        {
            this.IsVisible = true;
        }
    }
}
