using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Game.Models;

namespace RockPaperScissors.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}
