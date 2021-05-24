using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WCC_PM25.Controllers
{
    public class ManagementController : Controller
    {
        public IActionResult Users()
        {
            return View();
        }
    }
}
