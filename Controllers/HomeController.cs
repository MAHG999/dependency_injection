using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCDeémpendencyInjectionType.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDeémpendencyInjectionType.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransient _transient;
        private readonly IScoped _scoped;
        private readonly ISingleton _singleton;

        public HomeController(ITransient transient, IScoped scoped, ISingleton singleton)
        {
            _transient = transient;
            _scoped = scoped;
            _singleton = singleton;
        }

        public IActionResult Index()
        {
            ViewBag.transient = _transient;
            ViewBag.scoped = _scoped;
            ViewBag.singleton = _singleton;

            return View();
        }

        
    }
}
