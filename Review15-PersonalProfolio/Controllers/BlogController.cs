using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Review15PersonalProfolio.Models;



namespace Review15PersonalProfolio.Controllers
{
    [Authorize]
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public BlogController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult BlogDisplayView()
        {
            
            if (_db.Responces != null)
            {
                var blogs = _db.Posts.Include(p => p.BlogResponces).ToList();
            return View(blogs);
            }
            else
            {
                var blogs = _db.Posts.ToList();
                return View(blogs);
            }

        }

        public IActionResult Create()
        {
          
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post post)
        {
            _db.Posts.Add(post);
            _db.SaveChanges();
            return RedirectToAction("BlogDisplayView");
        }

        public IActionResult Responce(int id, string title)
        {
            ViewBag.Id = id;
            ViewBag.PostTitle = title;
            return View();
        }

        [HttpPost]
        public IActionResult Responce(Responce responce)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            
            var postId = Int32.Parse(Request.Form["postId"]);
            var title = Request.Form["title"];
            var text = Request.Form["text"];
            Responce newResponce = new Responce(userId, postId, title, text);
            _db.Responces.Add(newResponce);
            _db.SaveChanges();
            return RedirectToAction("BlogDisplayView");

        }
    }
}
