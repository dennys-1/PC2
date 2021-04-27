using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC2.Models;

namespace PC2.Controllers
{
    public class PresentacionController : Controller
    {
        private readonly ILogger<PresentacionController> _logger;

        public PresentacionController(ILogger<PresentacionController> logger)
        {
            _logger = logger;
        }

        public IActionResult QuienesSomos()
        {
            return View();
        }

    }
}
