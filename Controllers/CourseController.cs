using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Basics.Models;

namespace Basics.Controllers
{
   
    public class CourseController : Controller
    {
        public IActionResult Details(int id)
        {
            if(id == null || id == 0)
            {
                return RedirectToAction("ListCourse","Course");
            }
            var cr = Repository.GetById(id);
            return View(cr);
        }

        public IActionResult ListCourse()
        {  
            
           return View(Repository.Courses);
        }
    }
}