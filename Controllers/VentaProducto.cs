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
    public class VentaProductoController : Controller
    {
        private readonly ILogger<VentaProductoController> _logger;

        public VentaProductoController(ILogger<VentaProductoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Venta()
        {
            return View();
        }

       
    }
}
