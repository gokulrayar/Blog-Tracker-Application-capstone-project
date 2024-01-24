using App_UI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App_UI.Controllers
{
    public class BlogController : Controller
    {


        private readonly App_UIContext _context;

        public BlogController(App_UIContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var webMVCContext = _context.BlogInfo.Include(b => b.EmpInfo);
            return View(await webMVCContext.ToListAsync());
        }
    }
}
