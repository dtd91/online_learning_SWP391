﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SWP391.Data;
using SWP391.Models;
using SWP391.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SWP391.Controllers.Admin
{
    [ServiceFilter(typeof(Filter))]
    public class DashBoardController : Controller
    {
        private readonly LearningDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public DashBoardController(LearningDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }


        public IActionResult DashBoard()
        {
            //var user = HttpContext.User;
            //if(!user.Identity.IsAuthenticated)
            //{
            //    return Redirect($"~/login");
            //}
            //var obj = _userManager.GetUserAsync(user);
            //this.ViewBag.User = obj.Result;
            var obj = GetCurrentUser();
            return View(obj);
        }

        
        public IActionResult RegistrationList()
        {
            var obj = GetCurrentUser();
            IEnumerable<Course> list = _db.Courses.Where(c => c.StatusId == "3");
            ViewBag.CourseRegis = list;
            return View(list);
        }

        public Task<AppUser> GetCurrentUser()
        {
            var user = HttpContext.User;
            var obj = _userManager.GetUserAsync(user);
            this.ViewBag.User = obj.Result;
            return obj;
        }
    }
}
