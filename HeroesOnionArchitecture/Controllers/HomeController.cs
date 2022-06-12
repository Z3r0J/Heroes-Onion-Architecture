using HeroesOnionArchitecture.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HeroesOnionArchitecture.Core.Application.Interfaces.Services.Heroes;

namespace HeroesOnionArchitecture.Controllers
{
    public class HomeController : Controller
    {
        public readonly IHeroServices _heroServices;
        public HomeController(IHeroServices heroServices)
        {
            _heroServices = heroServices;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _heroServices.GetAllViewModel());
        }
    }
}
