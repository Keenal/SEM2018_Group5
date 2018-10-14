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
        private readonly IUserRepository _userRepository;

        public HomeController(IUserService userService, IUserRepository userRepository)
        {
            _userService = userService;
            _userRepository = userRepository;
        }

        public IActionResult Index(Models.User user)
        {
            //user.Email = "kstest@test.com";
            //user.Password = "kspassword";
            //user.FirstName = "K";
            //user.LastName = "S";
            //user.Role = "student";

          //  UserController uc = new UserController(_userService);

          //  uc.RegisterUser(user);
         //   uc.LoginUserX("kstest@test.com", "kspassword");
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
