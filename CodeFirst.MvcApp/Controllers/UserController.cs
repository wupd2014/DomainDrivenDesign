using CodeFirst.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst.MvcApp.Controllers
{
    public class UserController : Controller
    {
        public readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;

        }
        public ActionResult Index()
        {
            var list = _userService.GetUserList();
            return View();
        }

    }
}
