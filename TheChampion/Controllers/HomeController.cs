using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheChampion.Models;
using TheChampion.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.Extensions.DependencyInjection;
using TheChampion.ViewModels;

namespace TheChampion.Controllers
{

    public class HomeController : Controller
    {
        IServiceProvider serviceProvider;


        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Login()
        {
            var vm = new ViewModels.LoginViewModel
            {
                LoginName = "",
                LoginPassword = ""
            };
            return View(vm);
        }

        
        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            var db = new TheChampionContext();
            var account = db.Accounts.FirstOrDefault(a => a.LoginName == loginViewModel.LoginName);
            if (account!=null)
            {
                if(account.LoginPassword == loginViewModel.LoginPassword)
                {
                    return Redirect("/home/dashboard/" + account.AccountId);
                }
                else
                {
                    var vm = new ViewModels.LoginViewModel
                    {
                        LoginName = "",
                        LoginPassword = "",
                        Error = "Girdiğiniz şifre hatalı, lütfen tekrar deneyiniz."
                };
                    return View(vm);
                }
            }
            else
            {
                var vm = new ViewModels.LoginViewModel
                {
                    LoginName = "",
                    LoginPassword = "",
                    Error = "Kullanıcı adı bulunamadı, lütfen tekrar deneyiniz."
                };
                return View(vm);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
