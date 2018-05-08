using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Review15PersonalProfolio.Controllers
{
    [Authorize]
    public class Admin : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateBlog()
        {
            return RedirectToAction("Blog", "Create");
        }

        public IActionResult CreatePicture()
        {
            return RedirectToAction("Picture", "Create");
        }
    }
}
