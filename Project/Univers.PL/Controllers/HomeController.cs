﻿using Microsoft.AspNetCore.Mvc;
using Univers.Models.Models;

namespace Univers.PL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult StaffHome()
        {
            return View();
        }
        
        public ActionResult StudentHome(StudentModel student, int year = 0, int month = 0)
        {  
            DateTime currentDate = DateTime.Now;
            if (year == 0 || month == 0)
            {
                year = currentDate.Year;
                month = currentDate.Month;
            } 

            ViewBag.Year = year;
            ViewBag.Month = month;
        
            return View(student);
        }
    }
}
