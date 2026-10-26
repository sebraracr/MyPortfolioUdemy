using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.Models.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
