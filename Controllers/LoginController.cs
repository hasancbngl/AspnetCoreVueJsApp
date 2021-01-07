using Microsoft.AspNetCore.Mvc;
using my_vue_starter_new.ViewModel;

namespace my_vue_starter_new.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index([FromBody]Form form)
        {
            return View();
        }
    }


}

namespace my_vue_starter_new.ViewModel
{
     public class Form
    {
        public string FullName { get; set; }
        public string Email { get; set; }

        public string password { get; set; }
    }
}
