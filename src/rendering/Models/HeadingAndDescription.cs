using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace dotnetcore_xp_demo.Models
{
    public class HeadingAndDescription : HeadingOnly
    {
        public RichTextField Description { get; set; } = default!;
    }
}
