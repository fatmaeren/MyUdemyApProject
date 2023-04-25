using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }
        public IActionResult PartialView()
        {
            return PartialView();
        }

        public IActionResult HeaderView()
        {
            return PartialView();
        }

        public IActionResult SidebarView()
        {
            return PartialView();
        }
        public IActionResult FooterView()
        {
            return PartialView();
        }
    }
}
