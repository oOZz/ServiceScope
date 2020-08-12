using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Manager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceScope.Models;
using ServiceScope.Services;

namespace ServiceScope.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ISingletonService _singleton;
        private ITransientService _transient;
        private IScopeService _scoped;
        private IUserManager _uManager;

        public HomeController(ILogger<HomeController> logger, 
                              ISingletonService singleton,
                              ITransientService transient,
                              IScopeService scoped,
                              IUserManager uManager)
        {
            _logger = logger;
            _singleton = singleton;
            _transient = transient;
            _scoped = scoped;
            _uManager = uManager;
        }

        public IActionResult Index()
        {
            ViewData["umanager"] = _uManager.GetGuid();
            return View("Index", _singleton.GetGuid());
        }

        public IActionResult Transient()
        {
            return View("Transient", _transient.GetGuid());
        }

        public IActionResult Scoped()
        {
            return View("Scoped", _scoped.GetGuid());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
