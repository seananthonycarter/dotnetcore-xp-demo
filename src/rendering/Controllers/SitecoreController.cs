using Microsoft.AspNetCore.Mvc;
using Sitecore.AspNet.RenderingEngine.Binding.Attributes;
using Sitecore.LayoutService.Client.Response.Model;

namespace dotnetcore_xp_demo.Controllers
{
    public class SitecoreController : Controller
    {
        public IActionResult Index([SitecoreRouteField] Field<string> pageTitle)
        {
            ViewBag.Title = "Hello world"; // pageTitle.Value;

            return View();
        }

    }
}
