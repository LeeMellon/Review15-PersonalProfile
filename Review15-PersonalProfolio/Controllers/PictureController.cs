using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Review15PersonalProfolio.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Review15PersonalProfolio.Controllers
{
    public class PictureController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public PictureController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Index()
        {
            var picsList = _db.Pictures.ToList();
            return View(picsList);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Picture picture)
        {
            _db.Pictures.Add(picture);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete()
        {
            ViewBag.PictureId = new SelectList(_db.Pictures, "PictureId", "Url");
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int PictureId)
        {
            var thisPic = _db.Pictures.FirstOrDefault(p => p.PictureId == PictureId);
            _db.Pictures.Remove(thisPic);
            _db.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }
    }
}