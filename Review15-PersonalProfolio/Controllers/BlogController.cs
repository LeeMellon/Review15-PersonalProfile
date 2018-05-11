﻿using System.Dynamic;
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

        public IActionResult PostDisplayView(int id)
        {
            var thisPost = _db.Posts.Include(p => p.BlogResponces).Where(p => p.PostId == id).ToList();
            return View(thisPost);
        }


        public IActionResult BlogDisplayView()
        {


            var postWithResponceList = _db.Posts.Include(p => p.BlogResponces);
            if (_db.Responces != null)
            {
                List<Post> blogs = new List<Post> { };
                foreach(Post p in _db.Posts.Include(p => p.BlogResponces).ToList())
                {
                    p.GetBlurb();
                    blogs.Add(p);
                }

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

        
        public IActionResult Delete()
        {
            ViewBag.PostId = new SelectList(_db.Posts, "PostId", "Title");
             return View();
        }

        [HttpPost]
        public IActionResult Delete(int PostId)
        {
            var idInput = PostId;
            var thisPost = _db.Posts.FirstOrDefault(p => p.PostId == PostId);
            _db.Posts.Remove(thisPost);
            _db.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }
    }
}
