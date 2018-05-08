using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Review15PersonalProfolio.Models;



namespace Review15PersonalProfolio.Controllers
{
    [Authorize]
    public class ResponceController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public ResponceController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        

        public IActionResult Create(int id, string title)
        {
            ViewBag.Id = id;
            ViewBag.PostTitle = title;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Responce responce)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var thisUser = _db.Users.FirstOrDefault(u => u.Id == userId);
            var profileName = thisUser.ProfileName;
            var postId = Int32.Parse(Request.Form["postId"]);
            var title = Request.Form["title"];
            var text = Request.Form["text"];
            Responce newResponce = new Responce(userId, profileName, postId, title, text);
            _db.Responces.Add(newResponce);
            _db.SaveChanges();
            return RedirectToAction("BlogDisplayView", "Blog");

        }

        public IActionResult Delete()
        {
            ViewBag.ResponceId = new SelectList(_db.Responces, "ResponceId", "ResponceTitle");
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int ResponceId)
        {
            var thisResponce = _db.Responces.FirstOrDefault(p => p.ResponceId == ResponceId);
            _db.Responces.Remove(thisResponce);
            _db.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }
    }
}
