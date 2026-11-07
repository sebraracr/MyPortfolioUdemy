using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
    public class DashboardController : Controller
    {
        private readonly MyPortfolioContext _context;
        public DashboardController(MyPortfolioContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            ViewBag.messageCount = _context.Messages.Count();

            ViewBag.messageReadByTrueCount = _context.Messages
                .Where(x => x.IsRead == true).Count();

            ViewBag.messageReadByFalseCount = _context.Messages
                .Where(x => x.IsRead == false).Count();
            var lastMessages = _context.Messages
    .OrderByDescending(x => x.SendDate)
    .Take(3)
    .ToList();

            return View(lastMessages);

        }
    }
}
