using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace dotnetcore_xp_demo.Models
{
    public class FieldUsageFile : HeadingAndDescription
    {
        public FileField File { get; set; } = default!;
    }
}
