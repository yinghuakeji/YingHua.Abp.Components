using Microsoft.AspNetCore.Components;
using System;
using System.Drawing;
using System.Threading.Tasks;

namespace YingHua.Abp.SyncfusionUI.Components
{
    public partial class ToolbarButton : ComponentBase
    {
        [Parameter]
        public Color Color { get; set; }

        [Parameter]
        public object Icon { get; set; }

        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public Func<Task> Clicked { get; set; }

        [Parameter]
        public bool Disabled { get; set; }
    }
}
