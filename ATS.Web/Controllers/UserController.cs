using ATS.Data;
using ATS.Service;
using ATS.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ATS.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly IProfileService profileService;

        public UserController(IUserService userService, IProfileService profileService)
        {
            this.userService = userService;
            this.profileService = profileService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<UserViewModel> model = new List<UserViewModel>();
            userService.GetUsers().ToList().ForEach(u =>
            {
                Profile userProfile = profileService.GetUserProfile(u.Id);
                UserViewModel user = new UserViewModel
                {
                    UserName = u.UserName,
                    Id = u.Id,
                    Name = $"{userProfile.SurName} {userProfile.Name}",
                    Email = u.Email,
                    Address = userProfile.Address
                };
                model.Add(user);
            });
            return View(model);
        }
        [HttpGet]
        public ActionResult AddUser()
        {
            UserViewModel model = new UserViewModel();
            return PartialView("_AddUser", model);
        }
        [HttpPost]
        public ActionResult AddUser(UserViewModel model)
        {
            User userEntity = new User
            {
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password,
                CreatedDate = DateTime.UtcNow,
               
                Profile = new Profile
                {
                    SurName = model.SurName,
                    Name = model.Name,
                    Address = model.Address,
                    CreatedDate = DateTime.UtcNow,
                }
            };
            userService.InsertUser(userEntity);
            if (userEntity.Id > 0)
            {
                return RedirectToAction("index");
            }
            return View(model);
        }
    }
}
