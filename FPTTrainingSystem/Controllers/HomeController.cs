﻿using FPTTrainingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace FPTTrainingSystem.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db 
                            = new ApplicationDbContext();
        public ActionResult Index()
        {
            
            var posts = db.Posts.Include(p => p.Author).OrderByDescending(p => p.Date).Take(3);
            //we pass posts.ToList() as the value for the Model variable
            ViewBag.PostList = posts.ToList();
            return View(posts.ToList());
            
        }

        
    }
}