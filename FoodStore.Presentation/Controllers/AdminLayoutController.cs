﻿using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Presentation.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
