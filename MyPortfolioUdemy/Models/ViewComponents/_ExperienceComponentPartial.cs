using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.Models.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
