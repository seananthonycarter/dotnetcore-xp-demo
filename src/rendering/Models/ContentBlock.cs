using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace dotnetcore_xp_demo.Models
{
    public class ContentBlock : HeadingOnly
    {
        public RichTextField Content { get; set; } = default!;
    }
}
