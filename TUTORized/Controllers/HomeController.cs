using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TUTORized.Repository;
using TUTORized.Repository.Abstract;
using TUTORized.Services;
using TUTORized.Services.Abstract;

namespace TUTORized.Controllers
{
    public class HomeController : Controller
    {
        //FOR TESTING PURPOSES ONLY
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            //BaseRepository br = new BaseRepository();
            //await br.TestConnection();
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
