//using Microsoft.AspNetCore.Mvc;
//using AuthLogin.Models.DTO;

//namespace AuthLogin.Controllers
//{
//    public class LoginController : Controller
//    {
//        private readonly LoginController _service;
//        public LoginController(LoginController service)
//        {
//            this._service = service;
//        }
//        public IActionResult Login()
//        {
//            return View();
//        }

//        [HttpPost]
//        public async Task<IActionResult> Login(AuthLogin model)
//        {
//            if (ModelState.IsValid)
//            {
//                var User = from m in this._service select m;
//                User = User.Where(s => s.username.Contains(model.username));
//                if (User.Count() != 0)
//                {
//                    if (User.First().password == model.password)
//                    {
//                        return RedirectToAction("Success");
//                    }
//                }
//            }
//            return RedirectToAction("Fail");
//        }

//        public IActionResult Success()
//        {
//            return View();
//        }

//        public IActionResult Fail()
//        {
//            return View();
//        }
//    }
//}
