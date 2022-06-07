using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using mvcexample.Context;

namespace mvcexample.Controllers
{
    public class AccountController : Controller
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<BookStoreUser> _userManager;
        private readonly SignInManager<BookStoreUser> _signInManager;
        private readonly ILogger<AccountController> _logger;

        public AccountController(BookStoreDbContext dbContext, RoleManager<IdentityRole> roleManager, UserManager<BookStoreUser> userManager, SignInManager<BookStoreUser> signInManager, ILogger<AccountController> logger)
        {
            _dbContext = dbContext;
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }
        // [HttpPost]
        // public async Task<ActionResult> RegisterAsync()
        // {

        // }
    }      
}