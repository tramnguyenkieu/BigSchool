using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BigSchool.Models;
using BigSchool.ViewModels;

using System.Web.Mvc;

namespace BigSchool.Controllers
{
    //lan2
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        // GET: Course
        //adsfafa
        ///fsdgrreycghb,jhm
        public CourseController()
        {
            _dbContext = new ApplicationDbContext();
        }
        
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
              Categories   = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}