using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheChampion.ViewModels.Home
{
    public class LoginViewModel
    {
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public bool RememberMe { get; set; }
        public bool HasError { get; set; }
        public string ErrorDesc { get; set; }
        public string ReturnUrl { get; internal set; }
    }
}