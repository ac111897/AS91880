using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS91880.Controllers
{
    [Route("/")]
    [ApiController]
    public class RerouteController : ControllerBase
    {
        private static readonly string _siteHome = "/Home";
        /// <summary>
        /// Reroutes "/" to the home page
        /// </summary>
        /// <returns></returns>
        [HttpGet("/")]
        public IActionResult RerouteMain()
        {
            return RedirectToPage(_siteHome);
        }
        /// <summary>
        /// Reroutes "/index" to the home page
        /// </summary>
        /// <returns></returns>
        [HttpGet("/index")]
        public IActionResult RerouteIndex()
        {
            return RedirectToPage(_siteHome);
        }
    }
}
