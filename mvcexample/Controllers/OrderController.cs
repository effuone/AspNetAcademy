using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mvcexample.Controllers
{
    public class OrderController : Controller
    {
        private readonly BookStoreDbContext _context;
        private readonly ILogger<OrderController> _logger;

        public OrderController(BookStoreDbContext context, ILogger<OrderController> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            var books = await _context.Books.ToListAsync();
            return View(books);
        }
    }   
}
