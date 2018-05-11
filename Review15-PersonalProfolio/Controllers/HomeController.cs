﻿using System;
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
            return RedirectToAction("Index");
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
            var newCall = new ApiCall();
            var bulkRepos = newCall.GetStarred();
            return View(bulkRepos);
        }
    }
}
