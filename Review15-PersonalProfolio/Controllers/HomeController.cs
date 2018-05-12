using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Review15PersonalProfolio.Models;

namespace Review15PersonalProfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {

            return View();
        }

        public IActionResult Contact()
        {

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult GetRepos()
        {
            
            return View();
        }

        //public IActionResult ReposDisplayView()
        //{
        //    var newCall = new ApiCall();
        //    var repos = newCall.GetRepos().ToList();
        //    return View( repos);
        //}

        public IActionResult StarredDsiplayView()
        {
            var newCall = new ApiCall();
            var repos = newCall.GetStarred();
            return View(repos);
        }
    }
}
