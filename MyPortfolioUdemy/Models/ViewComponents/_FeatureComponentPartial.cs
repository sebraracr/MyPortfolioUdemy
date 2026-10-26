using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.Models.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {  return View(); }
    }
}
