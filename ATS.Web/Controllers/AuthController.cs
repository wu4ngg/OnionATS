using ATS.Service;
using ATS.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ATS.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserService userService;
        public AuthController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            long id = userService.Login(model.Email, model.Password);
            if(id != -1)
            {
                return RedirectToAction("Index", "User");
            }
            return View(model);
        }
    }
}
