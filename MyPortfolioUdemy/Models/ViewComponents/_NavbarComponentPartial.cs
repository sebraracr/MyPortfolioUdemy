using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.Models.ViewComponents
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
