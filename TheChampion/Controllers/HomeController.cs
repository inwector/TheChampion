using System;
using System.Collections.Generic;
using System.Linq;
using TheChampion.ViewModels;
using TheChampion.Context;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace TheChampion.ViewModels
{
    public class HomeController : Controller
    {
        private TheChampionContext DbContext;

        public HomeController(TheChampionContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult login(string Error)
        {
            ViewBag.Error = Error;
            return View();
        }

        [HttpPost]
        public IActionResult login(string LoginName, string LoginPassword, string RememberMe, string ReturnUrl)
        {
            if (DbContext.Accounts.Where(a => a.LoginName == LoginName).Count() > 0)
            {
                var user = DbContext.Accounts.Where(a => a.LoginName == LoginName).First();
                if (user.LoginPassword == LoginPassword)
                {
                    return Redirect("/home/mainmenu");
                }
                else
                {
                    return View("Wrong password, please try again.");
                }
            }
            else
            {
                return View("LoginName does not exist, please register or try again.");
            }
        }


        [HttpGet]
        [Authorize(Policy = "UserOnly")]
        public IActionResult mainmenu()
        {
            
            return View();
        }

    }
}

