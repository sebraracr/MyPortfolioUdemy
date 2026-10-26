using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.Models.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
