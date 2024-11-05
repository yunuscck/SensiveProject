using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SensiveProject.EntityLayer.Concrete;
using SensiveProject.PresentationLayer.Models;

namespace SensiveProject.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            this._userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                Email = model.Email,
                Surname = model.Surname,
                UserName = model.UserName,
                ImageUrl = "test"
            };
            var result=await _userManager.CreateAsync(appUser,model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }
        }
    }
}
