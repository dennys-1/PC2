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
    public class CompraProductoController : Controller
    {
        private readonly ILogger<CompraProductoController> _logger;

        public CompraProductoController(ILogger<CompraProductoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Compra()
        {
            return View();
        }

       
    }
}
