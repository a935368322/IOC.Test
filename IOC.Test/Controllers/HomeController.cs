using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IOC.Interface;

namespace IOC.Test.Controllers
{
    public class HomeController : Controller
    {
        private IUserService userService;
        private IRoleService roleService;
        public HomeController(IUserService userService,IRoleService roleService)
        {
            this.userService = userService;
            this.roleService = roleService;
        }
        public ActionResult Index()
        {
            var usersList = userService.GetUsersList();
            var roleList = roleService.GetRoleList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}