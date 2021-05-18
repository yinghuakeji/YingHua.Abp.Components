namespace YingHua.Abp.SyncfusionUI.Components
{
    /// <summary>
    /// 面包屑
    /// </summary>
    public class BreadcrumbItem
    {
        public string Text { get; set; }

        public object Icon { get; set; }

        public string Url { get; set; }

        public BreadcrumbItem(string text, string url = null, object icon = null)
        {
            Text = text;
            Url = url;
            Icon = icon;
        }
    }
}