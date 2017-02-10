using MovieFeeler.Common;
using MovieFeeler.Manager.Imp;
using MovieFeeler.Manager.Interfaces;
using MovieFeeler.Model;
using MovieFeeler.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MovieFeeler.Web.Controllers
{
    public class AccountController : Controller
    {
        private IUserManager _userMgr;
        public AccountController()
        {
            _userMgr = new UserManager();
        }

        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            try
            {
                _userMgr.Register(user);
                FormsAuthentication.SetAuthCookie(user.username, true);
                return RedirectToAction("index", "home");
            }
            catch (AlreadyExistException ex)
            {
                ViewBag.msg = ex.Message;
                return View("Register");
            }
        }

        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {            
            if (_userMgr.Login(username, password))
            {
                FormsAuthentication.SetAuthCookie(username, true);
                return RedirectToAction("index", "home");
            }
            ViewBag.msg = "Invalid Username/Password.";
            return View("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("index", "home");
        }
    }
}
